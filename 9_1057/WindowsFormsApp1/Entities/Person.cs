using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    public enum Gender
    {
        NA,
        Male,
        Female
    }

    [Serializable]
    public class Person : IComparable<Person>
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

        public Person()
        { }

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

        public int CompareTo(Person other)
        {
            return BirthDate.CompareTo(other.BirthDate);
        }
    }
}
