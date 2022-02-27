using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class ProductDetail
    {
        public string ProductDetailId { get; set; } = null!;
        public string? ProductId { get; set; }
        public int? ProductType { get; set; }
        public string? ProductSku { get; set; }
        public string? Barcode { get; set; }
        public string? HashTag { get; set; }
        public string? Imei { get; set; }
        public string? ImagesDescription { get; set; }
        public string? Description { get; set; }
        public decimal? ImportPrice { get; set; }
        public decimal? ListedPrice { get; set; }
        public decimal? RetailPrince { get; set; }
        public int? NumberStockWaring { get; set; }
        public DateTime? TimeImportProduct { get; set; }
        public double? ProductHeight { get; set; }
        public double? ProductWidth { get; set; }
        public double? ProductLength { get; set; }
        public DateTime? TimeCreat { get; set; }
        public DateTime? TimeUpdate { get; set; }
        public DateTime? HandlerBy { get; set; }

        public virtual Product? Product { get; set; }
    }
}
