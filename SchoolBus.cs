using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class SchoolBus : Bus
    {
        public int numberOfSeats { get; set; }
        public SchoolBus(string brand, int length, int price, string color, int numberOfSeats) : base(brand, length, price, color) 
        {
            this.numberOfSeats = numberOfSeats;
        }
    }
}
