using Application.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistance.Context;
using Persistance.Repository;

namespace Persistance
{
    public static class PersistanceRegistration
    {
        public static IServiceCollection AddPersistenceDependencies(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<GamingNewsContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("SQLServer"));
            });

            service.AddScoped<ICategoryRepository, CategoryRepository>();
            service.AddScoped<INewsCategoryRepository, NewsCategoryRepository>();
            service.AddScoped<INewsCommentRepository, NewsCommentRepository>();
            service.AddScoped<INewsCommentReplyRepository, NewsCommentReplyRepository>();
            service.AddScoped<INewsRepository, NewsRepository>();
            service.AddScoped<INewsTagRepository, NewsTagRepository>();
            service.AddScoped<IUserRepository, UserRepository>();
            service.AddScoped<IUserLikeRepository, UserLikeRepository>();
            service.AddScoped<IUserSocialRepository, UserSocialRepository>();
            service.AddScoped<ITagRepository, TagRepository>();

            return service;
        }
    }
}