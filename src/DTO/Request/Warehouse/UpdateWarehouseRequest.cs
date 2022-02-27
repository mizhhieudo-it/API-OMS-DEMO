using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Request.Warehouse
{
    public class UpdateWarehouseRequest
    {
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
    }
}
