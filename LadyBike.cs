using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class LadyBike : Bicycle
    {
        public bool rack { get; set; }
        public LadyBike(string brand, int price, int gears, string color, bool rack) :base (brand, price, gears, color)
    {
        this.rack = rack;
    }

    }
}
