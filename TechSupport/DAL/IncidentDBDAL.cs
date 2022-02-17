using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// Incident DataAccessLayer designed to interface with the TechSupport DataBase.
    /// </summary>
    public class IncidentDBDAL
    {
        /// <summary>
        /// Retrieves all of the open Incidents in the DB.
        /// </summary>
        /// <returns>A list of Incident objects containing information on the open incidents</returns>
        public List<IncidentDB> GetOpenIncidents()
        {
            List<IncidentDB> openIncidentList = new List<IncidentDB>();

            string selectStatement =
                "SELECT ProductCode, DateOpened, c.Name AS'Customer', t.Name AS 'Technician', Title " +
                "FROM Incidents AS i " +
                "INNER JOIN Customers AS c ON (i.CustomerID = c.CustomerID) " +
                "LEFT JOIN Technicians AS t ON (i.TechID = t.TechID) " +
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
                            int technicianOrdinal = reader.GetOrdinal("Technician");

                            IncidentDB incident = new IncidentDB
                            {
                                ProductCode = reader.GetString(reader.GetOrdinal("ProductCode")),
                                DateOpened = reader.GetDateTime(reader.GetOrdinal("DateOpened")),
                                CustomerName = reader.GetString(reader.GetOrdinal("Customer")),
                                TechnicianName = reader.IsDBNull(technicianOrdinal) ? string.Empty : reader.GetString(technicianOrdinal),
                                Title = reader.GetString(reader.GetOrdinal("Title"))
                            };

                            openIncidentList.Add(incident);
                        }
                    }
                }
            }

            return openIncidentList;
        }

        /// <summary>
        /// If the Product is registered to the Product,
        /// creates a new Incident in the db from the Incident object.
        /// </summary>
        /// <param name="incident">The incident to add</param>
        /// <returns>Whether or not the insertion was successful</returns>
        public bool AddIncident(IncidentDB incident)
        {
            string selectQuery = @"SELECT COUNT(*)
                                   FROM Registrations
                                   WHERE CustomerID = @customerID
                                     AND ProductCode = @ProductCode";

            string insertStatement = @"INSERT INTO Incidents (CustomerID, ProductCode, DateOpened, Title, Description)
                                       VALUES (@customerID, @productCode, GetDate(), @title, @description)";
            
            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();

                using(SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.Add("@customerID", SqlDbType.Int);
                    cmd.Parameters["@customerID"].Value = incident.CustomerID;

                    cmd.Parameters.Add("@productCode", SqlDbType.VarChar);
                    cmd.Parameters["@productCode"].Value = incident.ProductCode;

                    if ((Int32)cmd.ExecuteScalar() < 1)
                        throw new Exception("Product is not registered to Customer");
                }
                
                using (SqlCommand cmd = new SqlCommand(insertStatement, connection))
                {
                    cmd.Parameters.Add("@customerID", SqlDbType.Int);
                    cmd.Parameters["@customerID"].Value = incident.CustomerID;

                    cmd.Parameters.Add("@productCode", SqlDbType.Char);
                    cmd.Parameters["@productCode"].Value = incident.ProductCode;

                    cmd.Parameters.Add("@title", SqlDbType.VarChar);
                    cmd.Parameters["@title"].Value = incident.Title;

                    cmd.Parameters.Add("@description", SqlDbType.VarChar);
                    cmd.Parameters["@description"].Value = incident.Description;

                    return cmd.ExecuteNonQuery() == 1;
                }
            }
        }
    }
}
