using System.Collections.Generic;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{

    /// <summary>
    /// Acts as a bridge between the Views and the TechnicianDAL
    /// </summary>
    public class TechnicianController
    {
        private readonly TechnicianDAL _technicianData;
        
        /// <summary>
        /// Creates the TechnicianController and initializes its DAL.
        /// </summary>
        public TechnicianController()
        {
            _technicianData = new TechnicianDAL();
        }

        /// <summary>
        /// Delegates retrieving all of the Technician from the db to the DAL
        /// </summary>
        /// <returns>All of the Technicians in the TechSupport database</returns>
        public List<Technician> GetTechnicians()
        {
            return _technicianData.GetTechnicians();
        }

        /// <summary>
        /// Delegates acquiring the Technician from their ID to the DAL
        /// </summary>
        /// <param name="techID">The ID of the Technician in question</param>
        /// <returns>A Technician object representing the entry</returns>
        public Technician GetTechnician(int techID)
        {
            return _technicianData.GetTechnician(techID);
        }
    }
}
