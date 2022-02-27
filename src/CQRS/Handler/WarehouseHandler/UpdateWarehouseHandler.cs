using CQRS.Commands.WarehouseCommand;
using Domain.Models;
using DTO.Respon.Warehouse;
using MediatR;
using OMS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork;

namespace CQRS.Handler.WarehouseHandler
{
    public class UpdateWarehouseHandler : IRequestHandler<UpdateWarehouseCommand, OMSResult>
    {
        private readonly IOMSUnitOfWork _UnitOfWork;
        public UpdateWarehouseHandler(IOMSUnitOfWork UnitOfWork)
        {
            _UnitOfWork =   UnitOfWork;
        }
        public Task<OMSResult> Handle(UpdateWarehouseCommand request, CancellationToken cancellationToken)
        {
            if(request.Warehouse == null)
            {
                throw new ArgumentNullException(nameof(request.Warehouse));
            }
            var warehouseEntity = new Warehouse
            {
                WarehouseId = request.Warehouse.WarehouseId,
                WarehouseName = request.Warehouse.WarehouseName,
                WarehouseNameContact = request.Warehouse.WarehouseNameContact,
                WarehouseNumber = request.Warehouse.WarehouseNumber,
                WarehouseAddress = request.Warehouse.WarehouseAddress,
                WarehousePostalCode = request.Warehouse.WarehousePostalCode,
                ProvinceId = request.Warehouse.ProvinceId,
                DistrinctId = request.Warehouse.DistrinctId,
                CommuneId = request.Warehouse.CommuneId,
                LocationMap = request.Warehouse.LocationMap
            };
            var updateWarehouse = _UnitOfWork.Warehouse.UpdateAsync(warehouseEntity);
            var warehouseRespon = new UpdateWarehouseRespon
            {
                WarehouseName = updateWarehouse.Result.WarehouseName,
                WarehouseNameContact = updateWarehouse.Result.WarehouseNameContact,
                WarehouseNumber = updateWarehouse.Result.WarehouseNumber,
                WarehouseAddress = updateWarehouse.Result.WarehouseAddress,
                WarehousePostalCode = updateWarehouse.Result.WarehousePostalCode,
                ProvinceId = updateWarehouse.Result.ProvinceId,
                DistrinctId = updateWarehouse.Result.DistrinctId,
                CommuneId = updateWarehouse.Result.CommuneId,
                LocationMap = updateWarehouse.Result.LocationMap,
            };
            return Task.FromResult(new OMSResult
            {
                success = true,
                data = warehouseRespon,
                message = "Update kho thành công" 
            });
        }
    }
}
