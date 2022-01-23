using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.Model
{
    public class Incident
    {
        public string Title { get; }

        public string Description { get; }

        public int CustomerID { get; }

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
            {
                throw new ArgumentException("CustomerID must be greater than or equal to zero");
            }

            Title = title.Trim();
            Description = description.Trim();
        }
    }
}
