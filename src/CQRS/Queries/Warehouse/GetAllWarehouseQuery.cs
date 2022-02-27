using MediatR;
using OMS.Common;
using OMS.Common.PaginationFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Queries.Warehouse
{
    public record GetAllWarehouseQuery(SearchRequest WarehousePagging) : IRequest<OMSResult>;
}
