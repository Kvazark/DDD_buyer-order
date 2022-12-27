using System;
using System.Collections.Generic;
using DDD.BuyerAgregate;

namespace DDD.Repository.Repositories
{
    public class BuyerRepository : IRepository<Buyer>
    {
      
        private List<Buyer> _buyers;

        public BuyerRepository()
        {
            _buyers = new List<Buyer>();
            // _buyers.Add(BuyerFactory.CreateBuyer(TypeOfPaymentMethod.Card, PaymentSystem.Mastercard));
            // _buyers.Add(BuyerFactory.CreateBuyer(TypeOfPaymentMethod.Cash, null));
        }


        public IEnumerable<Buyer> GetAll()
        {
            return _buyers;
        }

        public Buyer GetById(Guid id)
        {
            return _buyers.Find(buyer => buyer.Id == id);
        }

        public void Add(Buyer buyer)
        {
            _buyers.Add(buyer);
        }

        public void Update(Buyer buyer)
        {
            var findBuyer = _buyers.Find(entity => entity.Id == buyer.Id);
            if (findBuyer != null)
            {
                _buyers.Remove(findBuyer);
                _buyers.Add(buyer);
            }
        }
        

        public void Delete(Buyer buyer)
        {
            var findBuyer = _buyers.Find(entity => entity.Id == buyer.Id);
            if (findBuyer != null)
            {
                _buyers.Remove(findBuyer);
            }
        }
        
    }
}