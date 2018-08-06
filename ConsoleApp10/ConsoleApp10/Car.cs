using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp10;

namespace Cars
{
    abstract class Car: IDiscountable
    {
        private string _name;
        private string _color;
        private double _price;
        public double Discount { get; set; }
        //public Car(string name, string color, double price)
        //{
        //    Name = name;
        //    Color = color;
        //    Price = price;
        public string Name
        {
            get
            { return _name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty");
                }
                else
                {
                    _name = value;
                }
            }
        }
        public string Color
        {
            get
            { return _color; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Color cannot be null or empty");
                }
                else
                {
                    _color = value;
                }
            }
        }
        public double Price { get; set; }
        public virtual void SetDiscount(double discount)
        {
            Discount = discount;
            Price = Price - Price * Discount / 100;
        }
    }
}
