using System;

namespace DDD.OrderAgregate
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
            Random rnd = new Random();
            Id = rnd.Next(1000,10000);
        }

    }
}