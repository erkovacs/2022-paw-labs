using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRecap.Entities
{
    public class Airfield
    {
        int Id { get; set; }

        public List<Aircraft> Aircrafts { get; set; }

        public Airfield() { }
        public Airfield(int id)
        {
            Id = id;
            Aircrafts = new List<Aircraft>();
        }
    }
}
