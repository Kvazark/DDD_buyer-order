using System;

namespace DDD.BuyerAgregate
{
    public class BuyerRoot
    {
        public Guid Id = Guid.NewGuid();
        public string Name { get; set; }
        public string Address { get; set; }

        public BuyerRoot(string name, string address)
        {
            Name = name;
            Address = address;
        }
    }
}