using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    enum Gender
    {
        NA,
        Male,
        Female
    }

    [Serializable]
    class Person
    {
        #region Props

        private string _lastName;
        public string LastName 
        {
            get {
                return _lastName;
            }
            set {
                if(string.IsNullOrEmpty(value))
                {
                    throw new Exception("Last name cannot be null or empty.");
                }
                _lastName = value;
            }
        }

        public string FirstName { get; set; }

        public string Ssn { get; set; }

        public DateTime BirthDate { get; set; }

        public Gender Gender { get; set; }
        #endregion

        public Person(string lastName, string firstName, string ssn, DateTime birthDate, Gender gender)
        {
            LastName = lastName; // java style: this.setLastName(lastName)
            FirstName = firstName;
            Ssn = ssn;
            BirthDate = birthDate;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"{LastName} {FirstName}, {Ssn}, {BirthDate}, {Gender.ToString()}";
        }

    }
}
