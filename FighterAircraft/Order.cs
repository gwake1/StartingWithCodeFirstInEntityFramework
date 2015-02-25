using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FighterAircraft
{
    class Order
    {
        public int OrderId { get; set; }
        public string Customer { get; set; }
        public bool IsCompleted { get; set; }

        public Aircraft Aircraft { get; set; }
    }
}
