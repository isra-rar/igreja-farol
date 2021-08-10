using System.Collections.Generic;
using System.Threading.Tasks;
using FarolContext.Domain.Commands;
using FarolContext.Domain.Commands.Request;
using FarolContext.Domain.Commands.Response;
using FarolContext.Domain.Entities;
using FarolContext.Domain.Handler;
using FarolContext.Domain.Repositories;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FarolContext.WebApi.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class ChurchController : ControllerBase
    {

        private readonly IMediator _mediator;

        public ChurchController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public IEnumerable<Church> GetAll([FromServices] IChurchRepository respository)
        {
            return respository.GetAllChurchs();
        }

        [HttpPost]
        [Route("create")]
        public Task<GenericCommandResult<CreateChurchResponse>> Create(
            [FromBody] CreateChurchRequest command)
        {
            return _mediator.Send(command);
        }
    }
}