using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class DirtBike : Bicycle
    {
        public int wheelSize { get; set; }
        public DirtBike(string brand, int price, int gears, string color, int wheelSize) : base (brand, price, gears, color)
        {
            this.wheelSize = wheelSize;
        }
    }
}
