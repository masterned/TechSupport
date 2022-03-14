using System;

namespace TechSupport.Model
{
    /// <summary>
    /// Represents an Incident as stored in the TechSupport DataBase.
    /// </summary>
    public class Incident
    {
        private int _incidentID;
        private int _customerID;
        private string _customerName;
        private string _productCode;
        private int _techID;
        private DateTime _dateOpened;
        private DateTime _dateClosed;
        private string _title;
        private string _description;

        /// <summary>
        /// Property which dictates how the ProductCode field can be accessed and mutated.
        /// </summary>
        public int IncidentID
        {
            get => _incidentID;
            set
            {
                if (value < 0)
                    throw new ArgumentException("IncidentID must be greater than or equal to 0");

                _incidentID = value;
            }
        }

        /// <summary>
        /// Property which dictates how the CustomerID field can be accessed and mutated.
        /// </summary>
        public int CustomerID
        {
            get => _customerID;
            set
            {
                if (value < 0)
                    throw new ArgumentException("CustomerID must be greater than or equal to 0");

                _customerID = value;
            }
        }

        /// <summary>
        /// Property which dictates how the CustomerName field can be accessed and mutated.
        /// </summary>
        public string CustomerName
        {
            get => _customerName;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("CustomerName");

                _customerName = value;
            }
        }

        /// <summary>
        /// Property which dictates how the ProductCode field can be accessed and mutated.
        /// </summary>
        public string ProductCode
        { 
            get => _productCode;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("ProductCode");
                
                _productCode = value;
            }
        }

        /// <summary>
        /// Property which dictates how the TechID field can be accessed and mutated.
        /// </summary>
        public int TechID
        {
            get => _techID;
            set
            {
                if (value < -1)
                    throw new ArgumentException("TechID must be greater than or equal to -1");

                _techID = value;
            }
        }

        /// <summary>
        /// Property which dictates how the TechnicianName field can be accessed and mutated.
        /// </summary>
        public string TechnicianName { get; set; }

        /// <summary>
        /// Property which dictates how the DateOpened field can be accessed and mutated.
        /// </summary>
        public DateTime DateOpened
        { 
            get => _dateOpened;
            set
            {
                if (value == null)
                    throw new ArgumentNullException("DateOpened");

                _dateOpened = value;
            }
        }

        /// <summary>
        /// Property which dictates how the DateClosed field can be accessed and mutated.
        /// </summary>
        public DateTime DateClosed { get => _dateClosed; set => _dateClosed = value; }

        /// <summary>
        /// Property which dictates how the IsClosed field can be accessed and mutated.
        /// </summary>
        public bool IsClosed { get; set; }

        /// <summary>
        /// Property which dictates how the Title field can be accessed and mutated.
        /// </summary>
        public string Title {
            get => _title;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Please make sure to add both a Title and a Description");

                _title = value;
            }
        }

        /// <summary>
        /// Property which dictates how the incident's description can be accessed and mutated.
        /// </summary>
        public string Description
        {
            get => _description;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Incident requires both a Title and Description");

                _description = value;
            }
        }
    }
}
