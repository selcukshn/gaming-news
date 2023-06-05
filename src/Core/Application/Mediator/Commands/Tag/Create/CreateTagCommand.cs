using MediatR;

namespace Application.Mediator.Commands.Tag.Create
{
    public class CreateTagCommand : IRequest<bool>
    {
        public string Title { get; set; }
    }
}