using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class Invoice
    {
        public Invoice()
        {
            Payments = new HashSet<Payment>();
        }

        public string InvoiceId { get; set; } = null!;
        public string? OrderId { get; set; }
        public DateTime? TimeCreate { get; set; }
        public string? HandlerBy { get; set; }

        public virtual Order? Order { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
