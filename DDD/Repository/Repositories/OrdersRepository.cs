using System;
using System.Collections.Generic;
using DDD.OrderAgregate;


namespace DDD.Repository.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        private static readonly List<Order> OrderList = new()
        {
            OrderFactory.CreateOrder(new Address("399021", "Рязань", "Московская", "32", "21")),
            OrderFactory.CreateOrder(new Address("78948542", "Москва", "9-я Парковая", "62", "19"))

        };

        public IEnumerable<Order> GetAll()
        {
            return OrderList;
        }

        public Order? GetById(Guid id)
        {
            return OrderList.Find(order => order.Id == id);
        }

        public void Add(Order order)
        {
            OrderList.Add(order);
        }

        public void Update(Order order)
        {
            var findOrder = OrderList.Find(entity => entity.Id == order.Id);
            if (findOrder != null)
            {
                OrderList.Remove(findOrder);
                OrderList.Add(order);
            }
        }

        public void Delete(Order order)
        {
            var findOrder = OrderList.Find(entity => entity.Id == order.Id);
            if (findOrder != null)
            {
                OrderList.Remove(findOrder);
            }
        }
    }
}