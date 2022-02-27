using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class PaymentMethod
    {
        public PaymentMethod()
        {
            Payments = new HashSet<Payment>();
        }

        public string PaymentMethodId { get; set; } = null!;
        public string? PaymentName { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
    }
}
