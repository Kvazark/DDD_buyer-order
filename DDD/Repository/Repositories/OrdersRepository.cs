using System;
using System.Collections.Generic;
using DDD.OrderAgregate;


namespace DDD.Repository.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        private List<Order> _orders;

        public OrderRepository()
        {
            _orders = new List<Order>();
            var order1 = OrderFactory.CreateOrder(new Address("399021", "Рязань", "Московская", "32", "21"));
            order1.AddProduct(new Product("Product 1", 5500.0));
            order1.GetStatusOrder(StatusOrder.confirmed);
            _orders.Add(order1);
            // _orders.Add(OrderFactory.CreateOrder(new Address("78948542", "Москва", "9-я Парковая", "62", "19")));
        }

        public IEnumerable<Order> GetAll()
        {
            return _orders;
        }

        public Order GetById(Guid id)
        {
            return _orders.Find(order => order.Id == id);
        }

        public void Add(Order order)
        {
            _orders.Add(order);
        }

        public void Update(Order order)
        {
            var findOrder = _orders.Find(entity => entity.Id == order.Id);
            if (findOrder != null)
            {
                _orders.Remove(findOrder);
                _orders.Add(order);
            }
        }

        public void Delete(Order order)
        {
            var findOrder = _orders.Find(entity => entity.Id == order.Id);
            if (findOrder != null)
            {
                _orders.Remove(findOrder);
            }
        }
    }
}