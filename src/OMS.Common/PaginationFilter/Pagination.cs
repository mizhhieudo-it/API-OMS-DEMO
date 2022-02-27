using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.Common.PaginationFilter
{
    public class Pagination
    {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public Pagination()
        {
            PageNumber = 1;
            PageSize = 10;
        }
        public Pagination(int pageSize,int pageNumber)
        {
            pageSize = pageSize <10 ? PageSize = 10 : pageNumber;
            pageNumber = pageNumber < 1 ? PageSize = 1 : pageNumber;

        }
    }
}
