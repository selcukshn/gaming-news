using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Persistance.Context
{
    public class GamingNewsContext : DbContext
    {
        public GamingNewsContext() { }
        public GamingNewsContext(DbContextOptions<GamingNewsContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Server=SELCUK\\SQLEXPRESS;Initial Catalog=GamingNews;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}