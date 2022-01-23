using System;

namespace TechSupport.Model
{
    /// <summary>
    /// Models an incident storing its title, description, and related customerID.
    /// </summary>
    public class Incident
    {
        public string Title { get; }

        public string Description { get; }

        public int CustomerID { get; }

        /// <summary>
        /// Creates a new Incident using the given values.
        /// </summary>
        /// <param name="title">The title to give the Incident</param>
        /// <param name="description">The description of the Incident</param>
        /// <param name="customerID">The customerID associated with the Incident</param>
        public Incident(string title, string description, string customerID)
        {
            if (string.IsNullOrEmpty(title.Trim()))
                throw new ArgumentException("Title cannot be empty");
            
            if (string.IsNullOrEmpty(description.Trim()))
                throw new ArgumentException("Description cannot be empty");

            if (string.IsNullOrEmpty(customerID.Trim()))
                throw new ArgumentException("CustomerID cannot be empty");

            try
            {
                CustomerID = int.Parse(customerID.Trim());
            }
            catch (FormatException)
            {
                throw new ArgumentException("CustomerID must be a number");
            }

            if (CustomerID < 0)
                throw new ArgumentException("CustomerID must be greater than or equal to zero");

            Title = title.Trim();
            Description = description.Trim();
        }
    }
}
