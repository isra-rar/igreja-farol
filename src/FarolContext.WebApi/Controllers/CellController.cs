using System.Threading.Tasks;
using FarolContext.Domain.Commands;
using FarolContext.Domain.Commands.Request;
using FarolContext.Domain.Commands.Response;
using FarolContext.Domain.Repositories;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FarolContext.WebApi.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class CellController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ICellRepository _cellRepository;

        public CellController(IMediator mediator, ICellRepository cellRepository)
        {
            _mediator = mediator;
            _cellRepository = cellRepository;
        }

        [HttpPost]
        [Route("create")]
        public Task<GenericCommandResult<CreateCellResponse>> Create(
            [FromBody] CreateCellRequest command) 
            => _mediator.Send(command);
    }
}