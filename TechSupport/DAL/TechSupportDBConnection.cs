using System.Data.SqlClient;

namespace TechSupport.DAL
{
    /// <summary>
    /// Sets up a connection to the TechSupport server.
    /// </summary>
    public static class TechSupportDBConnection
    {
        /// <summary>
        /// Creates and returns a new Connection to the TechSupport server.
        /// </summary>
        /// <returns>A Connection object linked to the TechSupport server</returns>
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=localhost;Initial Catalog=TechSupport;" +
                "Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
