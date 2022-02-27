using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.Common.PaginationFilter
{
    public class PageRespon<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalPage { get; set; }
        public int TotalRecord { get; set; }
        public List<T> Data { get; set; }

        public PageRespon(int pageNumber,int pageSize)
        {
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
        }

    }
}
