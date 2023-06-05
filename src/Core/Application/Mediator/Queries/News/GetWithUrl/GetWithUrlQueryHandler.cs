using Application.Models;
using Application.Repository;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Application.Mediator.Queries.News.GetWithUrl
{
    public class GetWithUrlQueryHandler : GenericHandler<INewsRepository, GetWithUrlQuery, GetWithUrlViewModel>
    {
        public GetWithUrlQueryHandler(INewsRepository repository, IMapper mapper) : base(repository, mapper) { }

        public override async Task<GetWithUrlViewModel> Handle(GetWithUrlQuery request, CancellationToken cancellationToken)
        {
            var result = await base.Repository.AsQueryable()
            .Include(e => e.NewsCategories).ThenInclude(e => e.Category)
            .Include(e => e.NewsTags).ThenInclude(e => e.Tag)
            .Include(e => e.NewsComments).ThenInclude(e => e.User)
            .Include(e => e.NewsComments).ThenInclude(e => e.NewsCommentReplies).ThenInclude(e => e.User)
            .Include(e => e.NewsLikes)
            .Include(e => e.User)
            .Where(e => e.Url == request.Url)
            .FirstOrDefaultAsync();

            if (result is null)
                throw new Exception("Bu url'e ait içerik bulunamadı");

            return new GetWithUrlViewModel()
            {
                Id = result.Id,
                Content = result.Content,
                Cover = result.Cover,
                CreatedDate = result.CreatedDate,
                Description = result.Description,
                Title = result.Title,
                Url = result.Title,
                LikeCount = result.NewsLikes.Count,
                CommentCount = result.NewsComments.Count,
                Author = new NewsDetailUserViewModel()
                {
                    Biography = result.User.Biography,
                    FirstName = result.User.FirstName,
                    LastName = result.User.LastName,
                    Image = result.User.Image,
                    Username = result.User.Username
                },
                Categories = result.NewsCategories.Select(e => new NewsCategoryViewModel()
                {
                    Title = e.Category.Title,
                    Url = e.Category.Url
                }),
                Comments = result.NewsComments.Select(e => new NewsCommentViewModel()
                {
                    Comment = e.Comment,
                    CommentDate = e.CommentDate,
                    FirstName = e.User.FirstName,
                    Image = e.User.Image,
                    LastName = e.User.Image,
                    Username = e.User.Username,
                    Replies = e.NewsCommentReplies.Select(c => new NewsCommentReplyViewModel()
                    {
                        FirstName = c.User.FirstName,
                        Image = c.User.Image,
                        LastName = c.User.Image,
                        Username = c.User.Username,
                        Reply = c.Reply,
                        ReplyDate = c.ReplyDate
                    })
                }),
                Tags = result.NewsTags.Select(e => new NewsTagViewModal()
                {
                    Title = e.Tag.Title,
                    Url = e.Tag.Url
                })
            };
        }
    }
}