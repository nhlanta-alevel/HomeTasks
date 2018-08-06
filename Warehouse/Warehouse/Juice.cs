using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    class Juice: Item
    {
        private string _name;
        private double _price;
        private int _expirTerm;
        public override string Name   
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
                
            }
        public override double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        public override int ExpirationTerm
        {
            get
            {
                return _expirTerm;
            }
            set
            {
                _expirTerm = value;
            }
        }
    }
}
