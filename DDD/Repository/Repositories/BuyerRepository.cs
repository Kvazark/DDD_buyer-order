using System;
using System.Collections.Generic;
using DDD.BuyerAgregate;

namespace DDD.Repository.Repositories
{
    public class BuyerRepository : IRepository<Buyer>
    {
        private static readonly List<Buyer> BuyerList = new()
        {
            BuyerFactory.CreateBuyer(TypeOfPaymentMethod.Card, PaymentSystem.Visa),
            BuyerFactory.CreateBuyer(TypeOfPaymentMethod.Cash, null)
        };

        public IEnumerable<Buyer> GetAll()
        {
            return BuyerList;
        }

        public Buyer? GetById(Guid id)
        {
            return BuyerList.Find(buyer => buyer.Id == id);
        }

        public void Add(Buyer buyer)
        {
            BuyerList.Add(buyer);
        }

        public void Update(Buyer buyer)
        {
            var findBuyer = BuyerList.Find(entity => entity.Id == buyer.Id);
            if (findBuyer != null)
            {
                BuyerList.Remove(findBuyer);
                BuyerList.Add(buyer);
            }
        }
        

        public void Delete(Buyer buyer)
        {
            var findBuyer = BuyerList.Find(entity => entity.Id == buyer.Id);
            if (findBuyer != null)
            {
                BuyerList.Remove(findBuyer);
            }
        }
        
    }
}