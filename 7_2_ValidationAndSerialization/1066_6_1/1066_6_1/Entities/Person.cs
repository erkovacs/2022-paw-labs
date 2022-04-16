using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1066_6_1.Entities
{
    public enum Gender
    {
        None,
        Male,
        Female
    }

    [Serializable]
    public class Person
    {
        private string _lastName;
        public string LastName 
        {
            get { return _lastName; }

            set 
            {
                _lastName = value;
            }
        }
        public string FirstName { get; set; }
        public string Ssn { get; set; }

        public DateTime BirthDate { get; set; }

        public Gender Gender { get; set; }

        public Person()
        {
            LastName = "N/A";
            FirstName = "N/A";
            Ssn = "N/A";
            Gender = Gender.Male;
            BirthDate = DateTime.Now;
        }

        public Person(string lastName, string firstName, string ssn,
            DateTime birthDate, Gender gender)
        {
            LastName = lastName;
            FirstName = firstName;
            Ssn = ssn;
            BirthDate = birthDate;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"{LastName} {FirstName}, {Ssn}, {BirthDate.ToString()}, {Gender}";
        }
    }
}
