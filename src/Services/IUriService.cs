using OMS.Common.PaginationFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IUriService
    {
        public Uri GetURL(string route, Pagination filter); 
    }
}
