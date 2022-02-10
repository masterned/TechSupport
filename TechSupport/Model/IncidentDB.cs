using System;

namespace TechSupport.Model
{
    /// <summary>
    /// Represents an Incident as stored in the TechSupport DataBase.
    /// </summary>
    public class IncidentDB
    {
        private string _productCode;
        private DateTime _dateOpened;
        private string _customerName;
        private string _title;

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
        /// Property which dictates how the DateOpened field can be accessed and mutated.
        /// </summary>
        public DateTime DateOpened { 
            get => _dateOpened;
            set
            {
                if (value == null)
                    throw new ArgumentNullException("DateOpened");

                _dateOpened = value;
            }
        }

        /// <summary>
        /// Property which dictates how the CustomerName field can be accessed and mutated.
        /// </summary>
        public string CustomerName {
            get => _customerName;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("CustomerName");

                _customerName = value;
            }
        }

        /// <summary>
        /// Property which dictates how the TechnicianName field can be accessed and mutated.
        /// </summary>
        public string TechnicianName { get; set; }

        /// <summary>
        /// Property which dictates how the Title field can be accessed and mutated.
        /// </summary>
        public string Title {
            get => _title;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Title");

                _title = value;
            }
        }

        /// <summary>
        /// Default empty constructor to allow fields to be added post object creation.
        /// </summary>
        public IncidentDB()
        {
        }

        /// <summary>
        /// Full constructor requiring all fields to be specified.
        /// </summary>
        /// <param name="productCode">The identifier for the affected product</param>
        /// <param name="dateOpened">The Date the ticket was submitted</param>
        /// <param name="customerName">The Customer's first and last name</param>
        /// <param name="technicianName">The Technician's first and last name</param>
        /// <param name="title">The title of the Ticket</param>
        public IncidentDB(string productCode, DateTime dateOpened, string customerName, string technicianName, string title)
        {
            ProductCode = productCode;
            DateOpened = dateOpened;
            CustomerName = customerName;
            TechnicianName = technicianName;
            Title = title;
        }
    }
}
