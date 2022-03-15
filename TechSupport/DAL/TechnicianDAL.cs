using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// Acts as a bridge between the Controllers and the Technicians table in the TechSupport db
    /// </summary>
    public class TechnicianDAL
    {
        /// <summary>
        /// Retrieves all of the Technicians in the TechSupport db
        /// </summary>
        /// <returns>A list of Technician objects, representing the Technicians table</returns>
        public List<Technician> GetTechnicians()
        {
            List<Technician> technicians = new List<Technician>();
            
            string selectStatement = "SELECT TechID, Name, Email, Phone FROM Technicians";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Technician technician = new Technician
                            {
                                TechID = reader.GetInt32(reader.GetOrdinal("TechID")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                Email = reader.GetString(reader.GetOrdinal("Email")),
                                Phone = reader.GetString(reader.GetOrdinal("Phone"))
                            };

                            technicians.Add(technician);
                        }
                    }
                }
            }

            return technicians;
        }

        /// <summary>
        /// Retrieves all Technicians with at least one Incident assignment.
        /// </summary>
        /// <returns>The list of Technicians with Incident assignment(s)</returns>
        public List<Technician> GetTechniciansWithIncidents()
        {
            List<Technician> technicians = new List<Technician>();

            string selectStatement = "SELECT DISTINCT t.TechID, Name, Email, Phone FROM Technicians AS t JOIN Incidents AS i ON t.TechID = i.TechID";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Technician technician = new Technician
                            {
                                TechID = reader.GetInt32(reader.GetOrdinal("TechID")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                Email = reader.GetString(reader.GetOrdinal("Email")),
                                Phone = reader.GetString(reader.GetOrdinal("Phone"))
                            };

                            technicians.Add(technician);
                        }
                    }
                }
            }

            return technicians;
        }

        /// <summary>
        /// Retrieves a Technician from the db using their ID
        /// </summary>
        /// <param name="techID">The ID of the Technician to find</param>
        /// <returns>A Technician object which represents the db entry</returns>
        public Technician GetTechnician(int techID)
        {
            Technician technician = null;

            string selectStatement = @"SELECT TOP 1 TechID, Name, Email, Phone
                                       FROM Technicians
                                       WHERE TechID = @techID
                                       ;";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(selectStatement, connection))
                {
                    cmd.Parameters.Add("techID", SqlDbType.Int);
                    cmd.Parameters["techID"].Value = techID;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            technician = new Technician
                            {
                                TechID = reader.GetInt32(reader.GetOrdinal("TechID")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                Email = reader.GetString(reader.GetOrdinal("Email")),
                                Phone = reader.GetString(reader.GetOrdinal("Phone"))
                            };
                        }
                    }
                }
            }

            return technician;
        }
    }
}
