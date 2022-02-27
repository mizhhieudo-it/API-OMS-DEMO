using DTO.Request.Warehouse;
using MediatR;
using OMS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Commands.WarehouseCommand
{
    public record UpdateWarehouseCommand(UpdateWarehouseRequest Warehouse) : IRequest<OMSResult>;

}
