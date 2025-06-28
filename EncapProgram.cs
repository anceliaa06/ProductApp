using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp
{
    internal class Product
    {
        private int id;
        private string name;
        private double price;
        private double discountPercentage;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public double DiscountPercentage
        {
            get { return discountPercentage; }
            set { discountPercentage = value; }
        }

        public double GetDiscountedPrice()
        {
            return Price - (Price * DiscountPercentage / 100);
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Price: {Price:C}, Discount: {DiscountPercentage}%, Discounted Price: {GetDiscountedPrice():C}";
        }
    }

}
