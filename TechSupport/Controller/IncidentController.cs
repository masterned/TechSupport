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
        private IncidentDAL IncidentData;
        private readonly IncidentDBDAL _incidentDBData;
        private readonly RegistrationDAL _registrationData;

        /// <summary>
        /// Creates a new IncidentController.
        /// </summary>
        public IncidentController()
        {
            IncidentData = new IncidentDAL();
            _incidentDBData = new IncidentDBDAL();
            _registrationData = new RegistrationDAL();
        }

        /// <summary>
        /// Collects all of the incidents in the system.
        /// </summary>
        /// <returns>All of the recorded incidents</returns>
        public List<Incident> GetIncidents()
        {
            return IncidentData.GetIncidents();
        }

        /// <summary>
        /// Collects a list of incidents tied to a CustomerID.
        /// </summary>
        /// <param name="customerID">The CustomerID to query</param>
        /// <returns>All of the incidents with a matching CustomerID</returns>
        public List<Incident> GetIncidentsOfCustomer(int customerID)
        {
            return IncidentData.GetIncidentsOfCustomer(customerID);
        }

        /// <summary>
        /// Delegates adding a new incident to the collection of incidents.
        /// </summary>
        /// <param name="newIncident">The new incident to be added.</param>
        public void AddIncident(Incident newIncident)
        {
            IncidentData.Add(newIncident);
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

            if (_registrationData.CustomerHasProductRegistration(customerID, productCode))
                throw new ArgumentException("Product is not registered to Customer");

            return _incidentDBData.AddIncident(new IncidentDB
            {
                CustomerID = customerID,
                ProductCode = productCode,
                Title = title,
                Description = description
            });
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
