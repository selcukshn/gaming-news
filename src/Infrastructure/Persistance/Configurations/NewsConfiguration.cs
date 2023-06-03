using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistance.Configurations.Base;

namespace Persistance.Configurations
{
    public class NewsConfiguration : BaseConfiguration<News>
    {
        public override void Configure(EntityTypeBuilder<News> builder)
        {
            base.Configure(builder);
            builder.Property(e => e.Url).HasMaxLength(200).IsRequired();
            builder.Property(e => e.Title).HasMaxLength(200).IsRequired();
            builder.Property(e => e.Content).IsRequired();
            builder.Property(e => e.Cover).IsRequired();
            builder.Property(e => e.CreatedDate).HasDefaultValueSql("getdate()").IsRequired(false);
            builder.Property(e => e.Description).HasMaxLength(500).IsRequired(false);

            builder.HasOne(e => e.User).WithMany(e => e.News).HasForeignKey(e => e.UserId);
        }
    }
}