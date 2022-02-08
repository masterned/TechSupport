using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    public class IncidentDBDAL
    {
        public List<IncidentDB> GetOpenIncidents()
        {
            List<IncidentDB> openIncidentList = new List<IncidentDB>();

            string selectStatement =
                "SELECT ProductCode AS 'ProductCode', DateOpened, c.Name AS 'Customer', t.Name AS 'Technician', Title" +
                "FROM Incidents AS i" +
                "INNER JOIN Customers AS c ON (i.CustomerID = c.CustomerID)" +
                "INNER JOIN Technicians AS t ON (i.TechID = t.TechID)" +
                "WHERE DateClosed IS NULL" +
                ";";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            IncidentDB incident = new IncidentDB
                            {
                                ProductCode = reader.GetString(reader.GetOrdinal("ProductCode")),
                                DateOpened = reader.GetDateTime(reader.GetOrdinal("DateOpened")),
                                CustomerName = reader.GetString(reader.GetOrdinal("Customer")),
                                TechnicianName = reader.GetString(reader.GetOrdinal("Technician")),
                                Title = reader.GetString(reader.GetOrdinal("Title"))
                            };

                            openIncidentList.Add(incident);
                        }
                    }
                }
            }

            return openIncidentList;
        }
    }
}
