using System;
using System.Collections.Generic;
using System.Linq;
using DDD.OrderAgregate;
using DDD.Repository.Context;

namespace DDD.Repository.Repositories
{
    public class OrdersRepository: IRepository<Order>
    {
        private readonly DbContext _context;
        private IRepository<Order> _repositoryImplementation;

        public OrdersRepository(DbContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
        }

        public IEnumerable<Order> GetList() => _context.Orders.Select(e => e.Value);

        public Order Get(int id) => _context.Orders[id];
        void IRepository<Order>.Create(Order item)
        {
            _repositoryImplementation.Create(item);
        }

        public Order Create(Order item)
        {
            _context.Orders.Add(item.Id, item);
            return item;
        }

        public void Update(Order item) => _context.Orders[item.Id] = item;

        public void Delete(int id) => _context.Orders.Remove(id);
        public void Save()
        {
            _repositoryImplementation.Save();
        }
    }
}