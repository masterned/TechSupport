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
        private IncidentDBDAL _incidentDBData;

        /// <summary>
        /// Creates a new IncidentController.
        /// </summary>
        public IncidentController()
        {
            IncidentData = new IncidentDAL();
            _incidentDBData = new IncidentDBDAL();
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
        /// 
        /// </summary>
        /// <param name="customerID"></param>
        /// <param name="productCode"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        public bool AddIncident(string customerIDString, string productCode, string title, string description)
        {
            if (string.IsNullOrEmpty(customerIDString))
                throw new Exception("CustomerID cannot be empty");

            int customerID;

            try
            {
                customerID = int.Parse(customerIDString);
            } catch (FormatException)
            {
                throw new Exception("CustomerID must be a number");
            }

            if (string.IsNullOrEmpty(productCode))
                throw new Exception("ProductCode cannot be empty");

            if (string.IsNullOrEmpty(title))
                throw new Exception("Title cannot be empty");

            if (string.IsNullOrEmpty(description))
                throw new Exception("Description cannot be empty");

            return _incidentDBData.AddIncident(customerID, productCode, title, description);
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
