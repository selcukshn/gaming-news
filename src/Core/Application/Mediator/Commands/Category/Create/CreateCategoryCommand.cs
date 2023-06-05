using MediatR;

namespace Application.Mediator.Commands.Category.Create
{
    public class CreateCategoryCommand : IRequest<bool>
    {
        public string Title { get; set; }
    }
}