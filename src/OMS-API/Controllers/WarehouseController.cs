using CQRS.Commands.WarehouseComand;
using CQRS.Commands.WarehouseCommand;
using CQRS.Queries.Warehouse;
using DTO.Request.Warehouse;
using DTO.Respon.Warehouse;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OMS.Common;
using OMS.Common.PaginationFilter;
using Services;

namespace OMS_API.Controllers
{
    [Route("Warehouse")]
    [ApiController]
    public class WarehouseController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IUriService _uriService;
        public WarehouseController(IMediator mediator, IUriService uriService)
        {
            _mediator = mediator;
            _uriService = uriService;
        }
        [HttpPost("add")]
        public async Task<IActionResult> AddWarehouse([FromBody]AddWarehouseRequest item)
        {
            var products = await _mediator.Send(new AddWarehouseCommand(item));
            return this.Ok(products);
        }
        [HttpPost("delete")]
        public async Task<IActionResult> AddWarehouse(RemoveWarehouseRequest idWarehouse)
        {
            var products = await _mediator.Send(new RemoveWarehouseCommand(idWarehouse));
            return this.Ok(products);
        }
        [HttpPost("update")]
        public async Task<IActionResult> UpdateWarehouse([FromBody] UpdateWarehouseRequest warehouseupdate)
        {
            var products = await _mediator.Send(new UpdateWarehouseCommand(warehouseupdate));
            return this.Ok(products);
        }
        [HttpPost("Get-All")]
        public async Task<IActionResult> GetAllWarehouse(SearchRequest WarehousePagging)
        {
            var products = await _mediator.Send(new GetAllWarehouseQuery(WarehousePagging));
            return this.Ok(products);
        }
    }
}
