namespace KamigoInventory.Domain.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public CountryCode Country { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
    }
}
