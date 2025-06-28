using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double DiscountPercentage { get; set; }

        // Default constructor
        public Product(int id, string name, double price, double discountPercentage)
        {
            Id = id;
            Name = name;
            Price = price;
            DiscountPercentage = discountPercentage;
        }

        public double GetDiscountedPrice()
        {
            return Price - (Price * DiscountPercentage / 100);
        }

        public override string ToString()
        {
            return $"Product ID: {Id}, Name: {Name}, Price: {Price:C}, Discount: {DiscountPercentage}%, Discounted Price: {GetDiscountedPrice():C}";
        }
    }

}
