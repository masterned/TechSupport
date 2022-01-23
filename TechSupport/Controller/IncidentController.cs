using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    public class IncidentController
    {
        private IncidentDAL IncidentData;

        public IncidentController()
        {
            IncidentData = new IncidentDAL();
        }

        public List<Incident> GetIncidents()
        {
            return IncidentData.GetIncidents();
        }

        public List<Incident> GetIncidentsOfCustomer(int customerID)
        {
            return IncidentData.GetIncidentsOfCustomer(customerID);
        }

        public void AddIncident(Incident newIncident)
        {
            IncidentData.Add(newIncident);
        }
    }
}
