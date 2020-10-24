namespace KamigoInventory.Domain.Models
{
    public class Vendor
    {
        public int VendorId { get; set; }
        public string CompleteName { get; set; }
        public string SearchName { get; set; }
        public string Website { get; set; }
        public string VATNumber { get; set; }
        public Currency Currency { get; set; }
    }
}
