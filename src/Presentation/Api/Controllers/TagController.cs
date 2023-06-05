using Api.Controllers.Base;
using Application.Mediator.Commands.Tag.Create;
using Application.Mediator.Queries.Tag.GetTag;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/tag")]
    public class TagController : ApiControllerBase
    {
        public TagController(IMediator mediator) : base(mediator) { }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await base.Mediator.Send(new GetTagQuery()));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateTagCommand command)
        {
            return Ok(await base.Mediator.Send(command));
        }
    }
}