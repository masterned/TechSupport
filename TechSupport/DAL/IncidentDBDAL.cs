using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.Model;

namespace TechSupport.DAL
{
    public class IncidentDBDAL
    {
        public List<IncidentDB> GetOpenIncidents()
        {
            List<IncidentDB> openIncidentList = new List<IncidentDB>();

            string selectStatementString =
                "SELECT ProductCode AS 'Product Code', CAST(DateOpened AS DATE) AS 'Date Opened', c.Name AS 'Customer', t.Name AS 'Technician', Title" +
                "FROM Incidents AS i" +
                "INNER JOIN Customers AS c ON (i.CustomerID = c.CustomerID)" +
                "INNER JOIN Technicians AS t ON (i.TechID = t.TechID)" +
                "WHERE DateClosed IS NULL" +
                ";";

            return openIncidentList;
        }
    }
}
