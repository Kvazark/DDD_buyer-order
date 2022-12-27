using System;

namespace DDD.OrderAgregate
{
    public enum TypeProduct
    {
        product1 = 1,
        product2 =2,
        product3 = 3,
        product4 =4,
        product5 = 5,
        product6 =6
        
    }

    public abstract class Product
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