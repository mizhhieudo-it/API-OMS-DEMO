using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class Supperlier
    {
        public Supperlier()
        {
            Products = new HashSet<Product>();
        }

        public string SupplierId { get; set; } = null!;
        public string? SupplierType { get; set; }
        public string? SupplierName { get; set; }
        public string? SupplierEmail { get; set; }
        public string? SupplierNumber { get; set; }
        public string? SupplierWebsite { get; set; }
        public string? SupplierAddress { get; set; }
        public string? SupplierTaxCode { get; set; }
        public string? SupplierZipCode { get; set; }
        public long? SupperlierBankNumber { get; set; }
        public int? SupperlierBankType { get; set; }
        public string? BankOwnerName { get; set; }
        public string? Note { get; set; }
        public int? SupperlierStatus { get; set; }
        public DateTime? TimeCreate { get; set; }
        public DateTime? TimeUpdate { get; set; }
        public string? HandlerBy { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
