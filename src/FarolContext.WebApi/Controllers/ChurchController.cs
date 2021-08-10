using System.Collections.Generic;
using FarolContext.Domain.Commands;
using FarolContext.Domain.Entities;
using FarolContext.Domain.Handler;
using FarolContext.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FarolContext.WebApi.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class ChurchController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Church> GetAll([FromServices] IChurchRepository respository)
        {
            return respository.GetAllChurchs();
        }

        [HttpPost]
        [Route("create")]
        public GenericCommandResult Create(
            [FromBody] CreateChurchCommand command,
            [FromServices] CreateChurchRequestHandler handler)
        {
            return (GenericCommandResult)handler.Handle(command);
        }
    }
}