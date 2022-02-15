using System;

namespace TechSupport.Model
{
    /// <summary>
    /// Represents the data associated with a Customer in the TechSupport database.
    /// </summary>
    public class Customer
    {
        private int _customerID;
        private string _name;

        /// <summary>
        /// Property which dictates how CustomerID can be mutated and accessed.
        /// </summary>
        public int CustomerID
        {
            get => _customerID;
            set
            {
                if (value < 0)
                    throw new ArgumentException("CustomerID must be greater than or equal to zero");

                _customerID = value;
            }
        }

        /// <summary>
        /// Property which dictates how the Customer's name can be mutated and accessed.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Name", "Name cannot be empty");

                _name = value;
            }
        }
    }
}
