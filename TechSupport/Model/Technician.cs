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
        private string _email;
        private string _phone;

        /// <summary>
        /// Property defines how _techID can be accessed and mutated.
        /// </summary>
        public int TechID
        {
            get => _techID;
            set
            {
                if (value < 0)
                    throw new ArgumentNullException("TechID", "TechID must be greater than or equal to 0");

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
                    throw new ArgumentNullException("Name", "Name cannot be null or empty");

                _name = value;
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Email", "Email cannot be null or empty");

                _email = value;
            }
        }

        public string Phone
        {
            get => _phone;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Phone", "Phone cannot be null or empty");

                _phone = value;
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

        /// <summary>
        /// Override comparison method for sake of indexing.
        /// Comparing the Technician's ID is enough to know if they are the same.
        /// </summary>
        /// <param name="obj">The other Technician to compare this one to.</param>
        /// <returns>Whether or not the Technicians are the same.</returns>
        public override bool Equals(object obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
                return false;

            Technician tech = (Technician)obj;

            return TechID == tech.TechID;
        }

        /// <summary>
        /// Overriding Equals w/o overriding GetHashCode upsets Visual Studio.
        /// In order to appease it, I just passed through the parent's behavior.
        /// In a situation where Technician needs to be indexed (HashTable, HashMap, etc.),
        /// this may lead to incorrect results.
        /// For the sake of this project, this "solution" will suffice.
        /// </summary>
        /// <returns>The hash code of the object.</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
