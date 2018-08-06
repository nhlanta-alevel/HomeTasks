using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public abstract class Item
    {
        public abstract string Name { get; set; }
        public abstract double Price { get; set; }
        public abstract int ExpirationTerm { get; set; }
        
        public DateTime Expiration(int expirationTerm)
        {
            DateTime dt = new DateTime();
            dt = DateTime.Today;
            ExpirationTerm = expirationTerm;
            return dt.AddDays(expirationTerm);

        }
        
    }
}
