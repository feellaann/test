using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class SportsCar : Car
    {
        
        public int horsePower { get; set; }
        public int engineSize { get; set; }
        public int newTonMeters { get; set; }
        public SportsCar(string brand, int price, string color, int doors, int horsePower, int engineSize, int newTonMeters) : base (brand, price, color ,doors)
    {
            this.newTonMeters = newTonMeters;
            this.horsePower = horsePower;
            this.engineSize = engineSize;
    }
    }
}
