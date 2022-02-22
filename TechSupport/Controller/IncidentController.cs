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
        private readonly IncidentDBDAL _incidentDBData;
        private readonly RegistrationDAL _registrationData;

        /// <summary>
        /// Creates a new IncidentController.
        /// </summary>
        public IncidentController()
        {
            _incidentDBData = new IncidentDBDAL();
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

            IncidentDB incident = new IncidentDB
            {
                CustomerID = customerID,
                ProductCode = productCode,
                Title = title,
                Description = description
            };


            if (!_registrationData.CustomerHasProductRegistration(customerID, productCode))
                throw new ArgumentException("Product is not registered to Customer");

            return _incidentDBData.AddIncident(incident);
        }


        /// <summary>
        /// Delegate acquiring all of the open incidents to its DataAccessLayer.
        /// </summary>
        /// <returns>The list of open incidents in the DB</returns>
        public List<IncidentDB> GetOpenIncidents()
        {
            return _incidentDBData.GetOpenIncidents();
        }
    }
}
