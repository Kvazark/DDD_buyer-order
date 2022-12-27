using System;
using System.Linq;
using DDD.BuyerAgregate;
using DDD.OrderAgregate;
using DDD.Repository.Repositories;

namespace DDD
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            var buyerRepository = new BuyerRepository();
            var allBuyers = buyerRepository.GetAll().ToList();
            foreach (var buyer in allBuyers)
            {
                Console.WriteLine(buyer.ToString());
            }
            buyerRepository.Add(BuyerFactory.CreateBuyer(TypeOfPaymentMethod.Cash, null));

            var findBuyer = buyerRepository.GetById(buyerRepository.GetAll().Last().Id);
            if (findBuyer != null)
            {
                Console.WriteLine(findBuyer.ToString());
            }

            Console.WriteLine("--------------------------------------------------------");

//------------------ Orders --------------------//

            var orderRepository = new OrderRepository();
            var allOrders = orderRepository.GetAll().ToList();
            foreach (var order in allOrders)
            {
                Console.WriteLine(order.ToString());
            }

            var order1 = OrderFactory.CreateOrder(new Address("987825","Санкт-Петербург", "2-я Утиная улица", "43","35"));
            order1.AddProduct(new Product("Product 1", 459));
            order1.AddProduct(new Product("Product 2", 1020));
            order1.GetStatusOrder(StatusOrder.onTheWay);

            orderRepository.Add(order1);

            var findOrder = orderRepository.GetById(order1.Id);
            if (findOrder != null)
            {
                Console.WriteLine(findOrder.ToString());
            }
        }
        public static int generateId()
        {
            Random rnd = new Random();
            int Id = rnd.Next(1000,10000);
            return Id;
        }
    }
}