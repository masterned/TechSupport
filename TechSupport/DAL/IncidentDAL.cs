using System;
using System.Collections.Generic;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// Acts as a mediator between the program and the Incident data storage.
    /// </summary>
    public class IncidentDAL
    {
        private static List<Incident> _incidents = new List<Incident>
        {
            new Incident("Window Crashes on Refresh", "Double clicking the refresh button on the checkout page crashes the app.", "437"),
            new Incident("Blank Screen on Repaint", "When listening to the main channel for more than an hour, the page becomes blank rather than repainting", "1002")
        };

        /// <summary>
        /// Collects all of the incidents in the storage.
        /// </summary>
        /// <returns>All recorded incidents</returns>
        public List<Incident> GetIncidents()
        {
            return _incidents;
        }

        /// <summary>
        /// Inserts a new Incident into the incident storage.
        /// </summary>
        /// <param name="newIncident">The new incident to add</param>
        public void Add(Incident newIncident)
        {
            if (newIncident is null)
                throw new ArgumentException("Cannot add a null Incident");

            _incidents.Add(newIncident);
        }

        /// <summary>
        /// Collects all Incidents associated with a CustomerID.
        /// </summary>
        /// <param name="customerID">The CustomerID to query</param>
        /// <returns>All Incidents associated with the given CustomerID</returns>
        public List<Incident> GetIncidentsOfCustomer(int customerID)
        {
            if (customerID < 0)
                throw new ArgumentException("CustomerID must be greater than or equal to zero");

            List<Incident> customerIncidents = _incidents.FindAll((Incident incident) =>
            {
                return incident.CustomerID == customerID;
            });

            if (customerIncidents.Count == 0)
                throw new KeyNotFoundException("CustomerID not found");

            return customerIncidents;
        }
    }
}
