using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class CategoryProduct
    {
        public CategoryProduct()
        {
            Products = new HashSet<Product>();
        }

        public string CategoryProductId { get; set; } = null!;
        public string? CategoryProductName { get; set; }
        public string? CategoryProductDescription { get; set; }
        public DateTime? TimeCreate { get; set; }
        public DateTime? TimeUpdate { get; set; }
        public string? HandlerBy { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
