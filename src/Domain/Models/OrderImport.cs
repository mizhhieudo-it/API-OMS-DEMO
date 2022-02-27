using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class OrderImport
    {
        public OrderImport()
        {
            Products = new HashSet<Product>();
        }

        public string OrderImportId { get; set; } = null!;
        public string? SupplierId { get; set; }
        public string? ToWarehouseId { get; set; }
        public string? ReferenceCode { get; set; }
        public int? ProductQuantity { get; set; }
        public decimal? ProductPrince { get; set; }
        public decimal? ProductTotal { get; set; }
        public DateTime? ExpectedDelivery { get; set; }
        public string? OrderNote { get; set; }
        public DateTime? TimeCreate { get; set; }
        public DateTime? TimeUpdate { get; set; }
        public string? HandlerBy { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
