using OMS.Common.PaginationFilter;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.Helpers
{
    public static class PaginationHelpers
    {
        public static PageRespon<T> Pagging<T>(List<T> listData, Pagination validFilter)
        {
            var respon = new PageRespon<T>(validFilter.PageNumber, validFilter.PageSize);
            // tổng bản ghi
            respon.TotalRecord = listData.Count;
            //tổng số page 
            respon.TotalPage = respon.TotalRecord % validFilter.PageSize == 0 ? respon.TotalRecord / validFilter.PageSize : respon.TotalRecord / validFilter.PageSize + 1;
            respon.Data = listData.Skip((validFilter.PageNumber - 1 )*  validFilter.PageSize).Take(validFilter.PageSize).ToList();
            return respon;
        }
    }
}
