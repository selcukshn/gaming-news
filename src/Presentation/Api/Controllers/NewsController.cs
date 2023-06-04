using Api.Controllers.Base;
using Application.Mediator.Commands.News.Create;
using Application.Mediator.Queries.News.GetFeatured;
using Application.Mediator.Queries.News.GetLatest;
using Application.Mediator.Queries.News.GetMostLiked;
using Application.Mediator.Queries.News.GetNews;
using Application.Mediator.Queries.News.GetTrending;
using Application.Mediator.Queries.News.GetWithUrl;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/news")]
    public class NewsController : ApiControllerBase
    {
        public NewsController(IMediator mediator) : base(mediator) { }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateNewsCommand command)
        {
            return Ok(await base.Mediator.Send(command));
        }

        [HttpGet]
        public async Task<IActionResult> GetNews([FromQuery] GetNewsQuery query)
        {
            return Ok(await base.Mediator.Send(query));
        }

        [HttpGet]
        [Route("{url}")]
        public async Task<IActionResult> GetWithUrl(string url)
        {
            return Ok(await base.Mediator.Send(new GetWithUrlQuery(url)));
        }

        [HttpGet]
        [Route("featured")]
        public async Task<IActionResult> GetFeatured([FromQuery] int count)
        {
            return Ok(await base.Mediator.Send(new GetFeaturedQuery(count)));
        }

        [HttpGet]
        [Route("latest")]
        public async Task<IActionResult> GetLatest([FromQuery] int count)
        {
            return Ok(await base.Mediator.Send(new GetLatestQuery(count)));
        }

        [HttpGet]
        [Route("trending")]
        public async Task<IActionResult> GetTrending([FromQuery] int count)
        {
            return Ok(await base.Mediator.Send(new GetTrendingQuery(count)));
        }
        [HttpGet]
        [Route("mostliked")]
        public async Task<IActionResult> GetMostLiked([FromQuery] GetMostLikedQuery query)
        {
            return Ok(await base.Mediator.Send(query));
        }


    }
}