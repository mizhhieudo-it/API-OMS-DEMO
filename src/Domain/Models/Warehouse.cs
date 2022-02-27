using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class Warehouse
    {
        public Warehouse()
        {
            Products = new HashSet<Product>();
            WhAreas = new HashSet<WhArea>();
        }

        public string WarehouseId { get; set; } = null!;
        public string? WarehouseName { get; set; }
        public string? WarehouseNameContact { get; set; }
        public string? WarehouseNumber { get; set; }
        public string? WarehouseAddress { get; set; }
        public string? WarehousePostalCode { get; set; }
        public int? ProvinceId { get; set; }
        public int? DistrinctId { get; set; }
        public int? CommuneId { get; set; }
        public string? LocationMap { get; set; }
        public DateTime? CreateBy { get; set; }
        public DateTime? UpdateBy { get; set; }
        public DateTime? HandlerBy { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<WhArea> WhAreas { get; set; }
    }
}
