using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class OrderExport
    {
        public OrderExport()
        {
            Products = new HashSet<Product>();
        }

        public string ExportOrderId { get; set; } = null!;
        public int? ProductQuantity { get; set; }
        public string? FromWarehouseId { get; set; }
        public string? ToWarehouseId { get; set; }
        public string? Note { get; set; }
        public DateTime? TimeChangeLocation { get; set; }
        public DateTime? TimeCreate { get; set; }
        public DateTime? TimeUpdate { get; set; }
        public string? HandlerBy { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
