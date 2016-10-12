using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Bicycle
    {
        public string brand { get; set; }
        public int price { get; set; }
        public int gears { get; set; }
        public string color { get; set; }
        public Bicycle(string brand, int price, int gears, string color)
        {
            this.brand = brand;
            this.price = price;
            this.color = color;
            this.gears = gears;

        }
    }
}
