using Application.Mediator.Queries.News.GetFeatured;
using Application.Mediator.Queries.News.GetLatest;
using Application.Mediator.Queries.News.GetTrending;
using Application.Mediator.Queries.News.GetWithUrl;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/news")]
    public class NewsController : ControllerBase
    {
        private readonly IMediator Mediator;
        public NewsController(IMediator mediator)
        {
            Mediator = mediator;
        }

        [HttpGet]
        [Route("{url}")]
        public async Task<IActionResult> GetWithUrl(string url)
        {
            return Ok(await Mediator.Send(new GetWithUrlQuery(url)));
        }

        [HttpGet]
        [Route("featured")]
        public async Task<IActionResult> GetFeatured([FromQuery] int count)
        {
            return Ok(await Mediator.Send(new GetFeaturedQuery(count)));
        }

        [HttpGet]
        [Route("latest")]
        public async Task<IActionResult> GetLatest([FromQuery] int count)
        {
            return Ok(await Mediator.Send(new GetLatestQuery(count)));
        }

        [HttpGet]
        [Route("trending")]
        public async Task<IActionResult> GetTrending([FromQuery] int count)
        {
            return Ok(await Mediator.Send(new GetTrendingQuery(count)));
        }

    }
}