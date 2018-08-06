using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars;
using ConsoleApp10;

namespace ConsoleApp10
{
    class Minivan: Car
    {
        public double ExtraDiscount { get; set; }
        public int PassengerSeat { get; set; }

        public override void SetDiscount(double discount)
        {
            base.SetDiscount(discount);
            DateTime dt = DateTime.Now;
            ExtraDiscount = dt.Month * 2;
            Price = Price- ExtraDiscount;
           
        }

    }
}
