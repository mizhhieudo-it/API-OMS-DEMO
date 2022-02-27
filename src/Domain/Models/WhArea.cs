using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class WhArea
    {
        public string IdWhArea { get; set; } = null!;
        public string? IdWarehouse { get; set; }
        public string? AreaName { get; set; }
        public string? Description { get; set; }
        public string? CreateBy { get; set; }
        public string? UpdateBy { get; set; }
        public string? HandlerBy { get; set; }

        public virtual Warehouse? IdWarehouseNavigation { get; set; }
    }
}
