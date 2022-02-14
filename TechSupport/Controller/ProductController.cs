using System.Collections.Generic;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// Acts as bridge between views and Product DAL.
    /// </summary>
    public class ProductController
    {
        /// <summary>
        /// Delegates retrieving all Products to ProductDAL.
        /// </summary>
        /// <returns>All Products in TechSupport database.</returns>
        public List<Product> GetAllProducts()
        {
            return ProductDAL.GetAllProducts();
        }
    }
}
