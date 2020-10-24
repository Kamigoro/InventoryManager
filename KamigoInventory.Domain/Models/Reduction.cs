using System;
using System.Collections.Generic;
using System.Text;

namespace KamigoInventory.Domain.Models
{
    public class Reduction
    {
        public int ReductionId { get; set; }
        public double PurchasedQuantity { get; set; }
        public double ReductionPercentage { get; set; }
    }
}
