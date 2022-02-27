using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class Inventory
    {
        public string? InventoryId { get; set; }
        public string? ProductId { get; set; }
        public int? QuantityPurchase { get; set; }
        public int? StockInHand { get; set; }
        public int? QuantitySold { get; set; }
        public int? QuantityLoss { get; set; }
    }
}
