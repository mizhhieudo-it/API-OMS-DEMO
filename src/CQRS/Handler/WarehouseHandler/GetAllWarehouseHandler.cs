using CQRS.Queries.Warehouse;
using MediatR;
using OMS.Common;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Abstractions;
using UnitOfWork;
using System.Web.Mvc;
using OMS.Common.PaginationFilter;
using Domain.Models;
using OMS.Helpers;

namespace CQRS.Handler.WarehouseHandler
{
    public class GetAllWarehouseHandler : IRequestHandler<GetAllWarehouseQuery, OMSResult>
    {
        private readonly IOMSUnitOfWork _unitOfWork;
        private readonly IUriService _uriService;
        public GetAllWarehouseHandler(IOMSUnitOfWork unitOfWork, IUriService uriService)
        {
            _unitOfWork = unitOfWork; 
            _uriService = uriService;
        }
        public Task<OMSResult> Handle(GetAllWarehouseQuery request, CancellationToken cancellationToken)
        {
            var listWarehouse = (dynamic)null;
            if (string.IsNullOrWhiteSpace(request.WarehousePagging.KeyWord))
            {
                listWarehouse = _unitOfWork.Warehouse.GetAll()
                .Where(x => x.WarehouseNameContact.
                Contains(request.WarehousePagging.KeyWord))
                .Where(x => x.WarehouseName.
                Contains(request.WarehousePagging.KeyWord)).ToList();
            }
            else
            {
                listWarehouse = _unitOfWork.Warehouse.GetAll().ToList();
            }
            


            var data = PaginationHelpers.Pagging<Warehouse>(listWarehouse,request.WarehousePagging.Paging);
             return Task.FromResult(new OMSResult
            {
                data = data,
            }); ;
        }
    }
}
