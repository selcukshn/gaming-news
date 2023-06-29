using Application.Models.Base;
using MediatR;

namespace Application.Mediator.Commands.News.Create
{
    public class CreateNewsCommand : IRequest<bool>
    {
        public string Title { get; set; }
        public string Cover { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public bool Featured { get; set; }

        // public Guid UserId { get; set; }

        // public ICollection<NewsCategory> NewsCategories { get; set; }
        // public ICollection<NewsTag> NewsTags { get; set; }
    }
}