using System;

namespace TechSupport.Model
{
    public class IncidentDB
    {
        private string _productCode;
        private DateTime _dateOpened;
        private string _customerName;
        private string _technicianName;
        private string _title;

        public string ProductCode
        { 
            get => _productCode;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Product Code cannot be empty or null");
                
                _productCode = value;
            }
        }

        public DateTime DateOpened { 
            get => _dateOpened;
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Date opened cannot be null");

                _dateOpened = value;
            }
        }

        public string CustomerName {
            get => _customerName;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Customer name cannot be null or empty");

                _customerName = value;
            }
        }

        public string TechnicianName {
            get => _technicianName;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Technician name cannot be null or empty");

                _technicianName = value;
            }
        }

        public string Title {
            get => _title;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Title cannot be null or empty");

                _title = value;
            }
        }

        public IncidentDB()
        {

        }

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
