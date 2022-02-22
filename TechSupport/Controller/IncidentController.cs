using System;
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
            if (string.IsNullOrEmpty(incidentIDString))
                throw new ArgumentException("Please enter an Incident ID. (Must be a number >= 0)");

            int incidentID;

            try
            {
                incidentID = int.Parse(incidentIDString);
                Incident incident = _incidentData.GetIncident(incidentID);

                if (incident == null)
                    throw new KeyNotFoundException("No incident with the ID: " + incidentIDString + " could be found.");
            }
            catch (FormatException)
            {
                throw new ArgumentException("Incident ID must be a number.");
            }

            return _incidentData.GetIncident(incidentID);
        }

        /// <summary>
        /// Appends the "Text To Add" to the Description if the result is <= 200 characters.
        /// </summary>
        /// <param name="incidentIDString">The ID of the incident to append to</param>
        /// <param name="currentDescription">The description being shown in the form at update time</param>
        /// <param name="textToAdd">The text to append to the end of the description</param>
        /// <returns>Whether or not the operation was successful</returns>
        public bool AppendToDescription(string incidentIDString, string currentDescription, string textToAdd)
        {
            try
            {
                int incidentID = int.Parse(incidentIDString);
                Incident incident = _incidentData.GetIncident(incidentID);

                if (incident.Description != currentDescription)
                    throw new Exception("Incident entry does not match input.\nPlease \"Get\" this incident again before attempting to update.");

                string newDescription = currentDescription + "\r\n<" + DateTime.Now.ToShortDateString() + "> " + textToAdd;

                if (newDescription.Length > 200)
                    throw new IncidentDescriptionOverflowException();

                _incidentData.UpdateDescription(incidentID, newDescription);

                return true;
            }
            catch (FormatException)
            {
                throw new Exception("Incident ID must be a number >= 0");
            }
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
