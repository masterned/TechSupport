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
                "SELECT ProductCode, DateOpened, c.Name AS 'Customer', t.TechID AS 'TechID', t.Name AS 'TechName', Title " +
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
                            int techIDOrdinal = reader.GetOrdinal("TechID");
                            int techNameOrdinal = reader.GetOrdinal("TechName");

                            Incident incident = new Incident
                            {
                                CustomerName = reader.GetString(reader.GetOrdinal("Customer")),
                                ProductCode = reader.GetString(reader.GetOrdinal("ProductCode")),
                                Technician = (reader.IsDBNull(techIDOrdinal) || reader.IsDBNull(techNameOrdinal))
                                    ? null
                                    : new Technician
                                        {
                                            TechID = reader.GetInt32(techIDOrdinal),
                                            Name = reader.GetString(techNameOrdinal)
                                        },
                                DateOpened = reader.GetDateTime(reader.GetOrdinal("DateOpened")),
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

            string selectStatement = @"SELECT TOP 1 IncidentID
                                            , c.name AS Customer
	                                        , ProductCode
                                            , i.TechID
	                                        , t.Name AS Technician
	                                        , Title
	                                        , DateOpened
                                            , DateClosed
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
                            int techIDOrdinal = reader.GetOrdinal("TechID");
                            int technicianOrdinal = reader.GetOrdinal("Technician");

                            incident = new Incident
                            {
                                IncidentID = reader.GetInt32(reader.GetOrdinal("IncidentID")),
                                CustomerName = reader.GetString(reader.GetOrdinal("Customer")),
                                ProductCode = reader.GetString(reader.GetOrdinal("ProductCode")),
                                Technician = (reader.IsDBNull(techIDOrdinal) || reader.IsDBNull(technicianOrdinal))
                                    ? null
                                    : new Technician
                                        {
                                            TechID = reader.GetInt32(reader.GetOrdinal("TechID")),
                                            Name = reader.GetString(technicianOrdinal)
                                        },
                                Title = reader.GetString(reader.GetOrdinal("Title")),
                                DateOpened = reader.GetDateTime(reader.GetOrdinal("DateOpened")),
                                Description = reader.GetString(reader.GetOrdinal("Description"))
                            };

                            int dateClosedOrdinal = reader.GetOrdinal("DateClosed");

                            if (!reader.IsDBNull(dateClosedOrdinal))
                                incident.DateClosed = reader.GetDateTime(dateClosedOrdinal);
                        }
                    }
                }
            }

            return incident;
        }

        /// <summary>
        /// Updates all editable values in a row in the Incident table.
        /// Checks the in-memory version of the old Incident against the db
        /// in order to prevent the table from being changed if the in-memory
        /// Incident is not up-to-date with the database.
        /// 
        /// The requirements of the project only require checking against the Description
        /// and ClosedDate, but for the sake of robustness and future-proofing,
        /// I added safety around all updated values.
        /// </summary>
        /// <param name="oldIncident">Old version of Incident used to verify race condition has not occurred</param>
        /// <param name="newIncident">Contains values to update the Incident row with</param>
        public void UpdateIncident(Incident oldIncident, Incident newIncident)
        {
            string updateStatement = @"UPDATE Incidents SET
                                        CustomerID = @CustomerID,
                                        ProductCode = @ProductCode,
                                        TechID = @TechID,
                                        DateOpened = @DateOpened,
                                        DateClosed = @DateClosed,
                                        Title = @Title,
                                        Description = @Description
                                       WHERE IncidentID = @OldIncidentID
                                        AND CustomerID = @OldCustomerID
                                        AND ((TechID IS NULL AND @OldTechID IS NULL) OR (TechID = @OldTechID))
                                        AND DateOpened = @OldDateOpened
                                        AND ((DateClosed IS NULL AND @OldDateClosed IS NULL) OR (DateClosed = @OldDateClosed))
                                        AND Title = @OldTitle
                                        AND Description = @OldDescription";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(updateStatement, connection))
                {
                    cmd.Parameters.Add("CustomerID", SqlDbType.Int);
                    cmd.Parameters["CustomerID"].Value = newIncident.CustomerID;

                    cmd.Parameters.Add("ProductCode", SqlDbType.Char);
                    cmd.Parameters["ProductCode"].Value = newIncident.ProductCode;

                    cmd.Parameters.Add("TechID", SqlDbType.Int);
                    if (newIncident.Technician == null)
                        cmd.Parameters["TechID"].Value = DBNull.Value;
                    else
                        cmd.Parameters["TechID"].Value = newIncident.Technician.TechID;

                    cmd.Parameters.Add("DateOpened", SqlDbType.DateTime);
                    cmd.Parameters["DateOpened"].Value = newIncident.DateOpened;

                    cmd.Parameters.Add("DateClosed", SqlDbType.DateTime);
                    if (newIncident.DateClosed == null)
                        cmd.Parameters["DateClosed"].Value = DBNull.Value;
                    else
                        cmd.Parameters["DateClosed"].Value = newIncident.DateClosed;

                    cmd.Parameters.Add("Title", SqlDbType.VarChar);
                    cmd.Parameters["Title"].Value = newIncident.Title;

                    cmd.Parameters.Add("Description", SqlDbType.VarChar);
                    cmd.Parameters["Description"].Value = newIncident.Description;

                    cmd.Parameters.Add("OldIncidentID", SqlDbType.Int);
                    cmd.Parameters["OldIncidentID"].Value = oldIncident.IncidentID;

                    cmd.Parameters.Add("OldCustomerID", SqlDbType.Int);
                    cmd.Parameters["OldCustomerID"].Value = oldIncident.CustomerID;

                    cmd.Parameters.Add("OldTechID", SqlDbType.Int);
                    if (oldIncident.Technician == null)
                        cmd.Parameters["OldTechID"].Value = DBNull.Value;
                    else
                        cmd.Parameters["OldTechID"].Value = oldIncident.Technician.TechID;

                    cmd.Parameters.Add("OldDateOpened", SqlDbType.DateTime);
                    cmd.Parameters["OldDateOpened"].Value = oldIncident.DateOpened;

                    cmd.Parameters.Add("OldDateClosed", SqlDbType.DateTime);
                    if (oldIncident.DateClosed == null)
                        cmd.Parameters["OldDateClosed"].Value = DBNull.Value;
                    else
                        cmd.Parameters["OldDateClosed"].Value = oldIncident.DateClosed;

                    cmd.Parameters.Add("OldTitle", SqlDbType.VarChar);
                    cmd.Parameters["OldTitle"].Value = oldIncident.Title;

                    cmd.Parameters.Add("OldDescription", SqlDbType.VarChar);
                    cmd.Parameters["OldDescription"].Value = oldIncident.Description;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Closes the Incident by setting its DateClosed to the current Date.
        /// </summary>
        /// <param name="incidentID">The Incident to close</param>
        public void CloseIncident(int incidentID)
        {
            string updateStatement = @"UPDATE Incidents
                                       SET DateClosed = GETDATE()
                                       WHERE IncidentID = @incidentID
                                       ;";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(updateStatement, connection))
                {
                    cmd.Parameters.Add("incidentID", SqlDbType.Int);
                    cmd.Parameters["incidentID"].Value = incidentID;

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
