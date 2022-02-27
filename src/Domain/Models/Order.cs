using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class Order
    {
        public Order()
        {
            Invoices = new HashSet<Invoice>();
            OrderDetails = new HashSet<OrderDetail>();
        }

        public string OrderId { get; set; } = null!;
        public DateTime? DateReceived { get; set; }
        public DateTime? DateRequired { get; set; }
        public DateTime? DateDelivered { get; set; }
        public string? OrderStatus { get; set; }
        public string? PackageCode { get; set; }
        public string? CustomerId { get; set; }
        public string? OrderNote { get; set; }
        public DateTime? TimeCreate { get; set; }
        public DateTime? TimeUpdate { get; set; }
        public string? HandlerBy { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
