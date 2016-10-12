using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Bus
    {
        public string brand { get; set; }
        public int length { get; set; }
        public int price { get; set; }
        public string color { get; set; }
        public Bus(string brand, int length, int price, string color)
        {
            this.brand = brand;
            this.length = length;
            this.price = price;
            this.color = color;
        }

    }
}
