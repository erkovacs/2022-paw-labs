using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRecap_1065.Entities
{
    public class Building
    {
        public List<Room> Rooms { get; set; }

        public Building()
        { 
            Rooms = new List<Room>();
        }

        public Building(List<Room> rooms)
        {
            Rooms = rooms;
        }
    }
}
