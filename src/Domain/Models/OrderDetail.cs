using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class OrderDetail
    {
        public string OrderDetailId { get; set; } = null!;
        public string? ProductId { get; set; }
        public string? OrderId { get; set; }
        public decimal? Prince { get; set; }
        public double? Discount { get; set; }
        public int? Quantity { get; set; }
        public DateTime? TimeCreate { get; set; }
        public DateTime? TimeUpdate { get; set; }
        public string? HandlerBy { get; set; }

        public virtual Order? Order { get; set; }
        public virtual Product? Product { get; set; }
    }
}
