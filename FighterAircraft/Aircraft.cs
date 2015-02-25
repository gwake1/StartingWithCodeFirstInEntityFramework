using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FighterAircraft
{
    class Aircraft
    {
        public int AircraftId { get; set; }
        public string Name { get; set; }
        public decimal Winspan { get; set; }
        public string Description { get; set; }
        public byte[] Photo { get; set; }

        public List<Order> Orders { get; set; }
    }
}
