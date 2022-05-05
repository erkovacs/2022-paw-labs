using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRecap_1065.Entities
{
    public class Room : IComparable<Room>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool HasProjector { get; set; }

        public Room (){}

        public Room (int id, string name, bool hasProjector)
        {
            Id = id;
            Name = name;
            HasProjector = hasProjector;
        }

        public int CompareTo(Room other)
        {
            return Id.CompareTo(other.Id);
        }
    }
}
