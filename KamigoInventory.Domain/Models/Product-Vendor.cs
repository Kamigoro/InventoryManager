using System;
using System.Collections.Generic;
using System.Text;

namespace KamigoInventory.Domain.Models
{
    public class Product_Vendor
    {
        public Product Product { get; set; }
        public Vendor Vendor { get; set; }
        public string VendorReference { get; set; }
        public int DeliveryDelay { get; set; }
        public decimal UnitPriceVATI { get; set; }
        public decimal UnitPriceVATE { get; set; }
        public DateTime LastPurchase { get; set; }
        public Unit PurchaseUnit { get; set; }
        public IEnumerable<Reduction> Reductions { get; set; }
    }
}
