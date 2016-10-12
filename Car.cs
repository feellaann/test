using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Car
    {
        public string brand { get; set; }
        public int price { get; set; }
        public string color { get; set; }
        public int doors { get; set; }
        public Car(string brand, int price, string color, int doors)
        {
            this.brand = brand;
            this.price = price;
            this.color = color;
            this.doors = doors;
        }
    }

}
