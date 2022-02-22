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
        /// <param name="incidentID">The ID of the Indicent in question</param>
        /// <returns>The Incident with the given ID</returns>
        public Incident GetIncident(int incidentID)
        {
            return _incidentData.GetIncident(incidentID);
        }
    }
}
