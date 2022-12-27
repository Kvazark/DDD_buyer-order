using System;
using System.Collections.Generic;
using System.Linq;
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
        public Guid Id { get; set; }
        // public Buyer Buyer { get; set; }
        
        public StatusOrder Status { get; private set; }
        
        public List<Product> Products { get; private set; }
        
        public Address Address { get; set; }
        
        public Order(Guid id,Address address)
        {
            Id = id;
            Address = address;
        }
        
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void GetStatusOrder(StatusOrder status)
        {
            Status = status;
        }
        public override string ToString()
        {
            return "Id: " + Id + " Product Count: " + Products.Count() + " Status: " + Status;
        }


       
    }
    
//фабрика
    public class OrderFactory
    {
        public static Order CreateOrder(Address address)
        {
            var order = new Order(Guid.NewGuid(), address);
            return order;
        }
    }
}