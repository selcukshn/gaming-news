using Api.Controllers.Base;
using Application.Mediator.Commands.Category.Create;
using Application.Mediator.Queries.Category.GetCategory;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/category")]
    public class CategoryController : ApiControllerBase
    {
        public CategoryController(IMediator mediator) : base(mediator) { }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCategoryCommand command)
        {
            return Ok(await base.Mediator.Send(command));
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await base.Mediator.Send(new GetCategoryQuery()));
        }
    }
}