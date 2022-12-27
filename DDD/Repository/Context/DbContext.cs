using System.Collections.Generic;
using DDD.BuyerAgregate;
using DDD.OrderAgregate;

namespace DDD.Repository.Context
{
    public class DbContext
    {
        public DbContext(Dictionary<int, Buyer> buyers, Dictionary<int, Order> orders, Dictionary<int, Product> products)
        {
            Buyers = buyers;
            Orders = orders;
            Products = products;
        }
        public Dictionary<int, Buyer> Buyers { get; set; }
        public Dictionary<int, Order> Orders { get; set; }
    
        public Dictionary<int, Product> Products { get; set; }
    }
}