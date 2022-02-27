using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public string CustomerId { get; set; } = null!;
        public string? CustomerName { get; set; }
        public string? CustomerNumber { get; set; }
        public int? CountryId { get; set; }
        public byte[]? ZipCode { get; set; }
        public string? ProvinceId { get; set; }
        public string? DistrictId { get; set; }
        public string? WardsId { get; set; }
        public string? CustomerAddress { get; set; }
        public string? Note { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
