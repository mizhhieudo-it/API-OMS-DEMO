using OMS.Common.PaginationFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.Common
{
    public class SearchRequest
    {
        public string KeyWord { get; set; }
        public Pagination Paging { get; set; }
    }
}
