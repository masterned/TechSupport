﻿using System;
using System.Collections.Generic;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// Acts as a mediator between Incident Models, DALs, and Views.
    /// </summary>
    public class IncidentController
    {
        private readonly IncidentDAL _incidentData;
        private readonly RegistrationDAL _registrationData;

        /// <summary>
        /// Creates a new IncidentController.
        /// </summary>
        public IncidentController()
        {
            _incidentData = new IncidentDAL();
            _registrationData = new RegistrationDAL();
        }

        private int ParseIncidentID(string incidentIDString)
        {
            if (string.IsNullOrEmpty(incidentIDString))
                throw new ArgumentException("Please enter an Incident ID. (Must be a number >= 0)");

            try
            {
                return int.Parse(incidentIDString);
            }
            catch (FormatException)
            {
                throw new ArgumentException("Incident ID must be a number >= 0.");
            }
        }

        /// <summary>
        /// Delegates adding a new Incident to the IncidentDAL.
        /// </summary>
        /// <param name="customerIDString">String representation of the Customer's ID</param>
        /// <param name="productCode">The Code of the Product referenced in the incident</param>
        /// <param name="title">The title of the new incident</param>
        /// <param name="description">The description of the new incident</param>
        /// <returns>Whether or not adding the incident was successful</returns>
        public bool AddIncident(string customerIDString, string productCode, string title, string description)
        {
            int customerID;

            try
            {
                customerID = int.Parse(customerIDString);
            }
            catch (FormatException)
            {
                throw new ArgumentException("CustomerID was not a number");
            }

            Incident incident = new Incident
            {
                CustomerID = customerID,
                ProductCode = productCode,
                Title = title,
                Description = description
            };


            if (!_registrationData.CustomerHasProductRegistration(customerID, productCode))
                throw new ArgumentException("Product is not registered to Customer");

            return _incidentData.AddIncident(incident);
        }


        /// <summary>
        /// Delegate acquiring all of the open incidents to its DataAccessLayer.
        /// </summary>
        /// <returns>The list of open incidents in the DB</returns>
        public List<Incident> GetOpenIncidents()
        {
            return _incidentData.GetOpenIncidents();
        }

        /// <summary>
        /// Delegates retrieving the Incident with the associated ID to the DAL.
        /// </summary>
        /// <param name="incidentIDString">The ID of the Indicent in question in string form</param>
        /// <returns>The Incident with the given ID</returns>
        public Incident GetIncident(string incidentIDString)
        {
            int incidentID = ParseIncidentID(incidentIDString);

            Incident incident = _incidentData.GetIncident(incidentID);

            if (incident == null)
                throw new KeyNotFoundException($"No incident with the ID: {incidentIDString} could be found.");
           
            return incident;
        }

        /// <summary>
        /// Delegates retrieving all open Incidents with the given Technician to the DAL.
        /// </summary>
        /// <param name="techID">The ID of the Technician to search for.</param>
        /// <returns>The list of open Incidents asssigned to the given Technician</returns>
        public List<Incident> GetOpenIncidentsWithTech(int techID)
        {
            return _incidentData.GetOpenIncidentsWithTech(techID);
        }

        /// <summary>
        /// Appends the text to add to the end of the description, formatting it appropriately.
        /// </summary>
        /// <param name="currentDescription">The Incident itself</param>
        /// <param name="textToAdd">The String to append onto the end of the Description</param>
        /// <returns>The newly formatted Description</returns>
        public string FormatDescriptionApend(string currentDescription, string textToAdd)
        {
            return $"{currentDescription}\r\n<{DateTime.Now.ToShortDateString()}> {textToAdd}";
        }

        /// <summary>
        /// Updates the incident in the database with a new Technician and/or more text in its description.
        /// </summary>
        /// <param name="oldIncident">The incident to update</param>
        /// <param name="selectedTechnician">The technician to assign to the incident</param>
        /// <param name="textToAdd">Text to add to the incident's description</param>
        public void UpdateIncident(Incident oldIncident, Technician selectedTechnician, string textToAdd)
        {
            if (oldIncident.IsClosed)
                throw new InvalidOperationException("Incident already closed. Cannot update a closed incident.");

            string newDescription = string.IsNullOrWhiteSpace(textToAdd)
                ? oldIncident.Description
                : FormatDescriptionApend(oldIncident.Description, textToAdd);

            if (oldIncident.Technician.Equals(selectedTechnician) && oldIncident.Description == newDescription)
                throw new Exception("No changes in fields. Cannot update with already stored information.");

            if (newDescription.Length > 200)
                throw new IncidentDescriptionOverflowException();

            UpdateIncidentWithTruncatedDescription(oldIncident, selectedTechnician, newDescription);
        }

        /// <summary>
        /// Updates the Incident while bypassing the description length check.
        /// </summary>
        /// <param name="oldIncident">The unchanged Incident as stored in memory</param>
        /// <param name="selectedTechnician">The Technician to assign the Incident to</param>
        /// <param name="newDescription">The new Description to give to the Incident</param>
        public void UpdateIncidentWithTruncatedDescription(Incident oldIncident, Technician selectedTechnician, string newDescription)
        {
            if (oldIncident.IsClosed)
                throw new InvalidOperationException("Incident already closed. Cannot update a closed incident.");

            if (oldIncident.Technician.Equals(selectedTechnician) && oldIncident.Description == newDescription)
                throw new Exception("No changes in fields. Cannot update with already stored information.");

            Incident newIncident = new Incident
            {
                IncidentID = oldIncident.IncidentID,
                CustomerID = oldIncident.CustomerID,
                ProductCode = oldIncident.ProductCode,
                Technician = selectedTechnician,
                DateOpened = oldIncident.DateOpened,
                DateClosed = oldIncident.DateClosed,
                Title = oldIncident.Title,
                Description = newDescription
            };

            _incidentData.UpdateIncident(oldIncident, newIncident);
        }

        /// <summary>
        /// Updates and closes the given incident.
        /// </summary>
        /// <param name="oldIncident">The Incident as stored in memory</param>
        /// <param name="selectedTechnician">The technician to assign to the Incident</param>
        /// <param name="textToAdd">The text to append to the Incident</param>
        public void CloseIncident(Incident oldIncident, Technician selectedTechnician, string textToAdd)
        {
            if (oldIncident.IsClosed)
                throw new InvalidOperationException("Incident already closed. Cannot close a closed incident.");

            string newDescription = string.IsNullOrWhiteSpace(textToAdd)
                ? oldIncident.Description
                : FormatDescriptionApend(oldIncident.Description, textToAdd);

            if (oldIncident.Technician.Equals(selectedTechnician) && oldIncident.Description == newDescription)
                throw new Exception("No changes in fields. Cannot update with already stored information.");

            if (newDescription.Length > 200)
                throw new IncidentDescriptionOverflowException();

            Incident newIncident = new Incident
            {
                IncidentID = oldIncident.IncidentID,
                CustomerID = oldIncident.CustomerID,
                ProductCode = oldIncident.ProductCode,
                Technician = selectedTechnician,
                DateOpened = oldIncident.DateOpened,
                DateClosed = DateTime.Now,
                Title = oldIncident.Title,
                Description = newDescription
            };

            _incidentData.UpdateIncident(oldIncident, newIncident);
        }

        /// <summary>
        /// Updates and closes the given incident while bypassing the Description length check.
        /// </summary>
        /// <param name="oldIncident">The Incident as stored in memory</param>
        /// <param name="selectedTechnician">The technician to assign to the Incident</param>
        /// <param name="newDescription">The new Description for the Incident</param>
        public void CloseIncidentUsingDescription(Incident oldIncident, Technician selectedTechnician, string newDescription)
        {
            if (oldIncident.IsClosed)
                throw new InvalidOperationException("Incident already closed. Cannot close a closed incident.");

            if (oldIncident.Technician.Equals(selectedTechnician) && oldIncident.Description == newDescription)
                throw new Exception("No changes in fields. Cannot update with already stored information.");

            Incident newIncident = new Incident
            {
                IncidentID = oldIncident.IncidentID,
                CustomerID = oldIncident.CustomerID,
                ProductCode = oldIncident.ProductCode,
                Technician = selectedTechnician,
                DateOpened = oldIncident.DateOpened,
                DateClosed = DateTime.Now,
                Title = oldIncident.Title,
                Description = newDescription
            };

            _incidentData.UpdateIncident(oldIncident, newIncident);
        }
    }

    /// <summary>
    /// Used to indicate when the new Incident description is beyond the maximum length.
    /// </summary>
    public class IncidentDescriptionOverflowException : Exception
    {
        /// <summary>
        /// Calls the base (super) contructor with the pre-fabricated message.
        /// </summary>
        public IncidentDescriptionOverflowException() : base("The description exceeds the 200 character maximum.") { }
    }
}
