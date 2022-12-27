using System;

namespace DDD.BuyerAgregate
{
    public class BuyerRoot
    {
        public Guid Id = Guid.NewGuid();
        public string Name { get; set; }
        public DateTime  DateOfB { get; set; }

        public BuyerRoot(string name, DateTime  dateOfB)
        {
            Name = name;
            DateOfB = dateOfB;
        }
    }
}