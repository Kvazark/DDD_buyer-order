using System;
using System.Collections.Generic;
using DDD.BuyerAgregate;

namespace DDD.OrderAgregate
{
    //перечисление статуса заказа
    public enum StatusOrder
    {
        inProcessing,
        confirmed,
        assembled,
        onTheWay,
        delivered
    }
    //заказ
    public class Order
    {
        public int Id { get; set; }
        public Buyer Buyer { get; set; }
        
        public StatusOrder Status { get; private set; }
        public List<Product> Products { get; set; }
        
        public Address AddressBuyer { get; set; }
        
        private Order()
        {
            Random rnd = new Random();
            Id = rnd.Next(10000,100000);
            Status = StatusOrder.onTheWay;
            Products = new List<Product>();
        }

        public Order(Buyer buyer)
        {
            Buyer = buyer;
        }

       
    }
    
//фабрика
    public class OrderFactory
    {
        public Order CreateOrder(Buyer buyer)
        {
            var order = new Order(buyer);
            return order;
        }
    }
}