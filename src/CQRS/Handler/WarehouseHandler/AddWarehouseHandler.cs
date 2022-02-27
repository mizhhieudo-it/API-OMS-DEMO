using CQRS.Commands.WarehouseComand;
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
    public class AddWarehouseHandler : IRequestHandler<AddWarehouseCommand, OMSResult>
    {
        private readonly IOMSUnitOfWork _unitOfWork;
        public AddWarehouseHandler(IOMSUnitOfWork unitOfWork)
        {
          _unitOfWork = unitOfWork;
        }
        public Task<OMSResult> Handle(AddWarehouseCommand request, CancellationToken cancellationToken)
        {
            if (request.Warehouse == null)
            {
                throw new ArgumentNullException(nameof(request.Warehouse));
            }
            var Warehouse = new Warehouse(
                request.Warehouse.WarehouseName,
                request.Warehouse.WarehouseNameContact,
                request.Warehouse.WarehouseNumber,
                request.Warehouse.WarehouseAddress,
                request.Warehouse.WarehouseNumber,
                request.Warehouse.ProvinceId,
                request.Warehouse.DistrinctId,
                request.Warehouse.CommuneId,
                request.Warehouse.LocationMap);
            var entity = _unitOfWork.Warehouse.Add(Warehouse);
            _unitOfWork.SaveChanges();
            var respon = new AddWarehouseRespon();
            respon.WarehouseName = entity.WarehouseName;
            respon.WarehouseNameContact = entity.WarehouseNameContact;
            respon.WarehouseNumber = entity.WarehouseNumber;
            respon.WarehouseAddress = entity?.WarehouseAddress;
            respon.WarehousePostalCode = entity?.WarehousePostalCode;
            respon.ProvinceId = entity?.ProvinceId;
            respon.DistrinctId = entity?.DistrinctId;
            respon.CommuneId = entity?.CommuneId;   
            respon.LocationMap = entity?.LocationMap;

            return Task.FromResult(new OMSResult
            {
                data = respon,
                message = "Thêm kho thành công"

            });
        }
    }
}
