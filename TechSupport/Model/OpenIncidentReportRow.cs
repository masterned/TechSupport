using System;

namespace TechSupport.Model
{
    /// <summary>
    /// Serves as a model to store the data of a row in the Open Incident Report.
    /// </summary>
    public class OpenIncidentReportRow
    {
        #region Fields
        private string _productName;
        private string _incidentTitle;
        private string _customerName;
        private DateTime _dateOpened;
        private string _technicianName;
        #endregion

        #region Properties
        /// <summary>
        /// Dictates the manner in which the Open Incident Report's product name can be accessed & mutated.
        /// </summary>
        public String ProductName
        {
            get => _productName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("ProductName", "The product's name cannot be null or empty.");

                _productName = value;
            }
        }

        /// <summary>
        /// Dictates the manner in which the Open Incident Report's incident title can be accessed & mutated.
        /// </summary>
        public String IncidentTitle
        {
            get => _incidentTitle;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("IncidentTitle", "The incident's title cannot be null or empty.");

                _incidentTitle = value;
            }
        }

        /// <summary>
        /// Dictates the manner in which the Open Incident Report's customer name can be accessed & mutated.
        /// </summary>
        public String CustomerName
        {
            get => _customerName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("CustomerName", "The customer's name cannot be null or empty.");

                _customerName = value;
            }
        }

        /// <summary>
        /// Dictates the manner in which the Open Incident Report's date opened can be accessed & mutated.
        /// </summary>
        public DateTime DateOpened { get => _dateOpened; set => _dateOpened = value; }

        /// <summary>
        /// Dictates the manner in which the Open Incident Report's product name can be accessed & mutated.
        /// </summary>
        public String TechnicianName
        {
            get => _technicianName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("TechnicianName", "The Technician's name cannot be null or empty.");

                _technicianName = value;
            }
        }
        #endregion
    }
}
