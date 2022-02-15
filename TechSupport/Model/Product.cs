using System;

namespace TechSupport.Model
{
    /// <summary>
    /// Represents the data associated with a Product in the TechSupport database.
    /// </summary>
    public class Product
    {
        private string _productCode;
        private string _name;

        /// <summary>
        /// Property which dictates how ProductCode can be mutated and accessed.
        /// </summary>
        public string ProductCode
        {
            get => _productCode;
            set => _productCode = value ?? throw new ArgumentNullException("ProductCode");
        }

        /// <summary>
        /// Property which dictates how Name can be mutated and accessed.
        /// </summary>
        public string Name
        {
            get => _name;
            set => _name = value ?? throw new ArgumentNullException("Name");
        }

        /// <summary>
        /// Overrides the ToString method to display the Product's name.
        /// </summary>
        /// <returns>The Product's name</returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
