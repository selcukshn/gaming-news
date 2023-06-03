using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Base
{
    public class ApiControllerBase : ControllerBase
    {
        protected readonly IMediator Mediator;
        public ApiControllerBase(IMediator mediator)
        {
            Mediator = mediator;
        }
    }
}