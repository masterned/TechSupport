using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// Incident DataAccessLayer designed to interface with the TechSupport DataBase.
    /// </summary>
    public class IncidentDAL
    {
        /// <summary>
        /// Retrieves all of the open Incidents in the DB.
        /// </summary>
        /// <returns>A list of Incident objects containing information on the open incidents</returns>
        public List<Incident> GetOpenIncidents()
        {
            List<Incident> openIncidentList = new List<Incident>();

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

                            Incident incident = new Incident
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
        /// Inserts a new Incident in the Incidents table in the
        /// TechSupport database based off of Incident object.
        /// </summary>
        /// <param name="incident">The incident to add</param>
        /// <returns>Whether or not the insertion was successful</returns>
        public bool AddIncident(Incident incident)
        { 
            string insertStatement = @"INSERT INTO Incidents (CustomerID, ProductCode, DateOpened, Title, Description)
                                       VALUES (@customerID, @productCode, GetDate(), @title, @description)";
            
            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();
                
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

        /// <summary>
        /// Returns the incident from the TechSupport database with the given ID
        /// </summary>
        /// <param name="incidentID">The ID of the incident to query for</param>
        /// <returns>The Incident associated with the given ID</returns>
        public Incident GetIncident(int incidentID)
        {
            Incident incident = null;

            string selectStatement = @"SELECT TOP 1 c.name AS Customer
	                                        , ProductCode
	                                        , t.name AS Technician
	                                        , Title
	                                        , DateOpened
	                                        , Description
                                       FROM Incidents AS i
	                                        JOIN Customers AS c ON i.CustomerID = c.CustomerID
	                                        LEFT JOIN Technicians AS t ON i.TechID = t.TechID
                                       WHERE IncidentID = @incidentID
                                       ;";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();

                using(SqlCommand cmd = new SqlCommand(selectStatement, connection))
                {
                    cmd.Parameters.Add("incidentID", SqlDbType.Int);
                    cmd.Parameters["incidentID"].Value = incidentID;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int technicianOrdinal = reader.GetOrdinal("Technician");

                            incident = new Incident
                            {
                                CustomerName = reader.GetString(reader.GetOrdinal("Customer")),
                                ProductCode = reader.GetString(reader.GetOrdinal("ProductCode")),
                                TechnicianName = reader.IsDBNull(technicianOrdinal) ? string.Empty : reader.GetString(technicianOrdinal),
                                Title = reader.GetString(reader.GetOrdinal("Title")),
                                DateOpened = reader.GetDateTime(reader.GetOrdinal("DateOpened")),
                                Description = reader.GetString(reader.GetOrdinal("Description"))
                            };
                        }
                    }
                }
            }

            return incident;
        }
    }
}
