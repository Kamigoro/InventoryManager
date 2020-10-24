using System.Collections;
using System.Collections.Generic;

namespace KamigoInventory.Domain.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Vendor MainVendor { get; set; }
        public IEnumerable<Vendor>  Vendors { get; set; }
        public Unit StockUnit { get; set; }
        public double MaximalQuantity { get; set; }
        public double MinimalQuantity { get; set; }
        public double CurrentQuantity { get; set; }
    }
}
