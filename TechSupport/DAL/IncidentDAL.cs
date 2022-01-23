using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.Model;

namespace TechSupport.DAL
{
    public class IncidentDAL
    {
        private static List<Incident> _incidents = new List<Incident>
        {
            new Incident("Window Crashes on Refresh", "Double clicking the refresh button on the checkout page crashes the app.", "WAL473"),
            new Incident("Blank Screen on Repaint", "When listening to the main channel for more than an hour, the page becomes blank rather than repainting", "SORCOM1002")
        };

        public List<Incident> GetIncidents()
        {
            return _incidents;
        }

        public void Add(Incident newIncident)
        {
            _incidents.Add(newIncident);
        }

        public List<Incident> GetIncidentsOfCustomer(string customerID)
        {
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
