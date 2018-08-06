using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Juice j = new Juice();
            j.Name = "Sandora";
            j.Price = 12.25;
            j.ExpirationTerm = 3;
            Console.WriteLine("{0}, {1}, {2}, {3}",j.Name, j.Price, j.ExpirationTerm,j.Expiration(5));
            Console.ReadLine();
        }
    }
}
