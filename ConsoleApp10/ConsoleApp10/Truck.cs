using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp10;

namespace Cars
{
    class Truck : Car
    {
        public double Capacity { get; set; }
        public double Milage { get; set; }
        public string Insurance { get; set; }

        public override void SetDiscount(double discount=30)
        {
           Price = Price - Price * discount / 100;
        }

    }
}
