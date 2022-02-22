using System;
using System.Data;
using System.Data.SqlClient;

namespace TechSupport.DAL
{
    /// <summary>
    /// Registration DataAccessLayer which acts as a bridge
    /// between the Controllers and the TechSupport database.
    /// </summary>
    public class RegistrationDAL
    {
        /// <summary>
        /// Checks the Registrations table to see if the specific product
        /// is registered to the given user.
        /// </summary>
        /// <param name="customerID">ID of the Customer to test</param>
        /// <param name="productCode">Code of the Product to test</param>
        /// <returns></returns>
        public bool CustomerHasProductRegistration(int customerID, string productCode)
        {
            string selectQuery = @"SELECT COUNT(*)
                                   FROM Registrations
                                   WHERE CustomerID = @customerID
                                     AND ProductCode = @ProductCode";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.Add("@customerID", SqlDbType.Int);
                    cmd.Parameters["@customerID"].Value = customerID;

                    cmd.Parameters.Add("@productCode", SqlDbType.VarChar);
                    cmd.Parameters["@productCode"].Value = productCode;

                    return (Int32)cmd.ExecuteScalar() >= 1;
                }
            }
        }
    }
}
