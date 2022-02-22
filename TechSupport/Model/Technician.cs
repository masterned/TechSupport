using System;

namespace TechSupport.Model
{
    /// <summary>
    /// Acts as an object representation of a Technician from the TechSupport database.
    /// </summary>
    public class Technician
    {
        private int _techID;
        private string _name;

        /// <summary>
        /// Property defines how _techID can be accessed and mutated.
        /// </summary>
        public int TechID
        {
            get => _techID;
            set
            {
                if (value < 0)
                    throw new ArgumentException("TechID must be greater than or equal to 0");

                _techID = value;
            }
        }

        /// <summary>
        /// Property defines how _name can be accessed and mutated.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Name cannot be null or empty");

                _name = value;
            }
        }

        /// <summary>
        /// Overrides the default ToString to return just the Technician's name
        /// </summary>
        /// <returns>The Technician's name</returns>
        public override string ToString()
        {
            return _name;
        }
    }
}
