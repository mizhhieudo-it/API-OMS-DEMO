using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class TransactionType
    {
        public TransactionType()
        {
            Payments = new HashSet<Payment>();
        }

        public string TransactionTypeId { get; set; } = null!;
        public string? TransactionName { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
    }
}
