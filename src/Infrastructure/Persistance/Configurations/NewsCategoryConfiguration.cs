using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistance.Configurations.Base;

namespace Persistance.Configurations
{
    public class NewsCategoryConfiguration : BaseConfiguration<NewsCategory>
    {
        public override void Configure(EntityTypeBuilder<NewsCategory> builder)
        {
            base.Configure(builder);
            builder.HasOne(e => e.Category).WithMany(e => e.NewsCategories).HasForeignKey(e => e.CategoryId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.News).WithMany(e => e.NewsCategories).HasForeignKey(e => e.CategoryId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}