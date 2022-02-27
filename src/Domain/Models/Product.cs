using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
            ProductDetails = new HashSet<ProductDetail>();
        }

        public string ProductId { get; set; } = null!;
        public string? ProductName { get; set; }
        public string? OrderDetailId { get; set; }
        public string? SupperlierId { get; set; }
        public string? TrademarkId { get; set; }
        public string? WarehouseId { get; set; }
        public string? CategoryProductId { get; set; }
        public string? OrderId { get; set; }
        public string? OrderImportId { get; set; }
        public string? OrderExportId { get; set; }
        public DateTime? TimeCreate { get; set; }
        public DateTime? TimeUpdate { get; set; }
        public string? HandlerBy { get; set; }

        public virtual CategoryProduct? CategoryProduct { get; set; }
        public virtual OrderExport? OrderImport { get; set; }
        public virtual OrderImport? OrderImportNavigation { get; set; }
        public virtual Supperlier? Supperlier { get; set; }
        public virtual Warehouse? Warehouse { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<ProductDetail> ProductDetails { get; set; }
    }
}
