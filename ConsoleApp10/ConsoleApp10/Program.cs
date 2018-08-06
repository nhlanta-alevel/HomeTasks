using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp10;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Truck truck = new Truck();
            truck.Name = "Kraz";
            truck.Color = "Green";
            truck.Milage = 150000;
            truck.Insurance = "He";
            truck.Price = 48000;
            truck.SetDiscount(100);
            Console.WriteLine("{0} {1} {2} {3} ", truck.Price, truck.Name, truck.Milage, truck.Insurance);
            Minivan mn = new Minivan();
            mn.Name = "Minivan";
            mn.PassengerSeat = 12;
            mn.Price = 48000;
            mn.SetDiscount(10);
            Console.WriteLine("{0} {1} {2} ", mn.Price, mn.Name, mn.PassengerSeat);
            Console.Read();
        }
    }
}
