using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.Model
{
    class Incident
    {
        public string Title { get; }

        public string Description { get; }

        public string CustomerID { get; }

        public Incident(string title, string description, string customerID)
        {
            if (string.IsNullOrEmpty(title.Trim()))
                throw new ArgumentNullException("Title cannot be empty");
            
            if (string.IsNullOrEmpty(description.Trim()))
                throw new ArgumentNullException("Description cannot be empty");

            if (string.IsNullOrEmpty(customerID.Trim()))
                throw new ArgumentNullException("CustomerID cannot be empty");

            Title = title.Trim();
            Description = description.Trim();
            CustomerID = customerID.Trim();
        }
    }
}
