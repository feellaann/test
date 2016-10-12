using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class MiniBus : Bus
    {
        public int miles { get; set; }
        public int fuel { get; set; }
        public MiniBus(string brand, int length, int price, string color, int miles, int fuel) : base (brand, length, price, color)
    {
        this.fuel = fuel;
        this.miles = miles;
    }

    }
}
