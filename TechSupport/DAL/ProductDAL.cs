using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    class ProductDAL
    {
        /// <summary>
        /// Retrieves all of the Products on the Products table in the TechSupport database.
        /// </summary>
        /// <returns>List containing all Products in TechSupport database</returns>
        public static List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            string selectStatement = "SELECT ProductCode, Name FROM Products";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = new Product
                            {
                                ProductCode = reader.GetString(reader.GetOrdinal("ProductCode")),
                                Name = reader.GetString(reader.GetOrdinal("Name"))
                            };

                            products.Add(product);
                        }
                    }
                }
            }

            return products;
        }
    }
}
