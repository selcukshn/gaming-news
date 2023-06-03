using Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistance.Configurations.Base;

namespace Persistance.Configurations
{
    public class CategoryConfiguration : BaseConfiguration<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            base.Configure(builder);
            builder.Property(e => e.Title).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Url).HasMaxLength(100).IsRequired();
        }
    }
}