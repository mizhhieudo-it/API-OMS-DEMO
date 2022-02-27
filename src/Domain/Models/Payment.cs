using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class Payment
    {
        public string PaymentId { get; set; } = null!;
        public string? InvoiceId { get; set; }
        public string? PaymentMethodId { get; set; }
        public string? TransactionTypeId { get; set; }
        public DateTime? TimeCreate { get; set; }
        public string? HandlerBy { get; set; }

        public virtual Invoice? Invoice { get; set; }
        public virtual PaymentMethod? PaymentMethod { get; set; }
        public virtual TransactionType? TransactionType { get; set; }
    }
}
