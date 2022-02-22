using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    public class TechnicianDAL
    {
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
