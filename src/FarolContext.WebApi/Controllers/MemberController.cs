using System.Threading.Tasks;
using FarolContext.Domain.Commands;
using FarolContext.Domain.Commands.Request;
using FarolContext.Domain.Commands.Response;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FarolContext.WebApi.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class MemberController : ControllerBase
    {
        private readonly IMediator _mediator;
        public MemberController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("create")]
        public Task<GenericCommandResult<CreateMemberResponse>> Create(
            [FromBody] CreateMemberRequest command) 
            => _mediator.Send(command);
    }
}