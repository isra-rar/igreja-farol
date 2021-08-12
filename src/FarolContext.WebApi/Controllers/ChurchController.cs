using System.Collections.Generic;
using System.Threading.Tasks;
using FarolContext.Domain.Commands;
using FarolContext.Domain.Commands.Request;
using FarolContext.Domain.Commands.Response;
using FarolContext.Domain.Entities;
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
        private readonly IChurchRepository _churchRepository;

        public ChurchController(IMediator mediator, IChurchRepository churchRepository)
        {
            _mediator = mediator;
            _churchRepository = churchRepository;
        }

        [HttpGet]
        public IEnumerable<Church> GetAll()
        {
            return _churchRepository.GetAllChurchs();
        }

        [HttpPost]
        [Route("create")]
        public Task<GenericCommandResult<CreateChurchResponse>> Create(
            [FromBody] CreateChurchRequest command) 
            => _mediator.Send(command);
    }
}