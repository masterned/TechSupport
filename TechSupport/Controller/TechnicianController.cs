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
        private  readonly TechnicianDAL _technicianData;
        
        public TechnicianController()
        {
            _technicianData = new TechnicianDAL();
        }
        
        public List<Technician> GetTechnicians()
        {
            return _technicianData.GetTechnicians();
        }
    }
}
