using System;

namespace SQLiteDb_1057.Entities
{
	internal class Participant
	{
		public long Id { get; set; }
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public DateTime BirthDate { get; set; }
	

		public Participant(string lastName, string firstName, DateTime birthDate)
		{
			LastName = lastName;
			FirstName = firstName;
			BirthDate = birthDate;
		}

		public Participant(long id, string lastName, string firstName, DateTime birthDate)
			: this(lastName, firstName, birthDate)
        {
			Id = id;
		}
	}
}
