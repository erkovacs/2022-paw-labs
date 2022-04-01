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

    class Person
    {
        #region Props
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Ssn { get; set; }

        public DateTime BirthDate { get; set; }

        public Gender Gender { get; set; }
        #endregion

        public Person(string lastName, string firstName, string ssn, DateTime birthDate, Gender gender)
        {
            LastName = lastName;
            FirstName = firstName;
            Ssn = ssn;
            BirthDate = birthDate;
            Gender = gender;
        }

        public static Person GetInstance()
        {
            return new Person("Kovacs", "Erik", "123", DateTime.Now, Gender.NA);
        }

        public override string ToString()
        {
            return $"{LastName} {FirstName}, {Ssn}, {BirthDate}, {Gender.ToString()}";
        }

    }
}
