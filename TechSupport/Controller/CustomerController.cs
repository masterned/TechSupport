using System.Collections.Generic;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// Acts as bridge between views and Customer DAL.
    /// </summary>
    public class CustomerController
    {
        /// <summary>
        /// Delegates retrieving all Customers to CustomerDAL.
        /// </summary>
        /// <returns>All Customers in TechSupport database.</returns>
        public List<Customer> GetAllCustomers()
        {
            return CustomerDAL.GetAllCustomers();
        }
    }
}
