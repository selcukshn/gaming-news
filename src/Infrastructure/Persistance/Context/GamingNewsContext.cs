using System.Reflection;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistance.Context
{
    public class GamingNewsContext : DbContext
    {
        public GamingNewsContext() { }
        public GamingNewsContext(DbContextOptions<GamingNewsContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Server=SELCUK\\SQLEXPRESS;Initial Catalog=GamingNews;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<NewsCategory> NewsCategories { get; set; }
        public DbSet<NewsComment> NewsComments { get; set; }
        public DbSet<NewsCommentReply> NewsCommentReplies { get; set; }
        public DbSet<UserLike> UserLikes { get; set; }
        public DbSet<NewsTag> NewsTags { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserSocial> UserSocials { get; set; }
    }
}