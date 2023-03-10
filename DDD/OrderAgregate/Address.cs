namespace DDD.OrderAgregate
{
    public class Address
    {
        private string Index { get; set; }
        
        private string City { get; set; }
        private string Street { get; set; }
        private string House { get; set; }
        private string Apartment { get; set; }

        public Address(string index, string city, string street, string house, string apartment)
        {
            Index = index;
            City = city;
            Street = street;
            House = house;
            Apartment = apartment;
        }
    }
}