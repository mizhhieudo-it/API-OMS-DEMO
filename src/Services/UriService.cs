using OMS.Common.PaginationFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UriService : IUriService
    {
        private readonly string _baseURL;
        public UriService(string baseURL)
        {
            _baseURL = baseURL;
        }
        public Uri GetURL(string route, Pagination filter)
        {
            var endPoint = new Uri(string.Concat(_baseURL,route));
            var addPageNumner = new Uri(string.Concat(endPoint.ToString(),filter.PageNumber.ToString()));
            var addPageSize = new Uri(string.Concat(addPageNumner.ToString(), filter.PageSize.ToString()));
            return addPageSize;
        }
    }
}
