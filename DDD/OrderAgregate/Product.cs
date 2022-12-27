using System;

namespace DDD.OrderAgregate
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        
        public Product(string name, double price)
        {
            Name = name;
            Price = (decimal) price;
            Id =  Guid.NewGuid();
        }

    }
}