using System;
using System.Collections.Generic;
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
            
            string selectStatement = "SELECT TechID, Name FROM Technicians";

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
                                Name = reader.GetString(reader.GetOrdinal("Name"))
                            };

                            technicians.Add(technician);
                        }
                    }
                }
            }

            return technicians;
        }
    }
}
