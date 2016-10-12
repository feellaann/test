using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Kombi : Car
    {
        public int trunkSize { get; set; }
        public bool hitch { get; set; }
         public Kombi(string brand, int price, string color, int doors, int trunkSize, bool hitch) : base (brand, price, color, doors)
    {
        this.hitch = hitch;
        this.trunkSize = trunkSize;
    }

    }
}
