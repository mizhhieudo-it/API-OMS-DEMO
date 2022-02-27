using DTO.Request.Warehouse;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using DTO.Respon.Warehouse;
using OMS.Common;

namespace CQRS.Commands.WarehouseComand
{
    public record AddWarehouseCommand(AddWarehouseRequest Warehouse) : IRequest<OMSResult>;
}
