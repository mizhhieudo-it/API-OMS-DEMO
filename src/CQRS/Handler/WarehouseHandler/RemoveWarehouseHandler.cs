using CQRS.Commands.WarehouseCommand;
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

    //                                                 => RemoveHandller ==> OSMResult
    public class RemoveWarehouseHandler : IRequestHandler<RemoveWarehouseCommand, OMSResult>
    {
        private readonly IOMSUnitOfWork _unitOfWorkBase;
        public RemoveWarehouseHandler(IOMSUnitOfWork unitOfWorkBase)
        {
            _unitOfWorkBase = unitOfWorkBase;
        }

        public  Task<OMSResult> Handle(RemoveWarehouseCommand request, CancellationToken cancellationToken)
        {
            
            var warehouseRemove = _unitOfWorkBase.Warehouse.GetById(request.Warehouse.IdWarehouseRequest);
            if(warehouseRemove == null)
            {
                throw new ArgumentNullException(nameof(request.Warehouse.IdWarehouseRequest));
            }
            else
            {
                var itemRemove = _unitOfWorkBase.Warehouse.DeleteAsync(warehouseRemove);
                _unitOfWorkBase.SaveChanges();
                var removeWarehouseRespon = new RemoveWarehouseRespon()
                {
                    IdWarehouseRemoveRespon = itemRemove.Result.WarehouseId,
                    NameWarehouseRemoveRespon = itemRemove.Result.WarehouseName,
                    AddressWarehouseRemoveRespon = itemRemove.Result.WarehouseAddress
                };
                return Task.FromResult(new OMSResult
                {
                    data = removeWarehouseRespon,
                    message = "Xóa kho thành  công"
                } );

            }
        }
    }
}
