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

        /// <summary>
        /// Creates a new IncidentController.
        /// </summary>
        public IncidentController()
        {
            IncidentData = new IncidentDAL();
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
    }
}
