using Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistance.Configurations.Base;

namespace Persistance.Configurations
{
    public class UserConfiguration : BaseConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.Property(e => e.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(e => e.LastName).HasMaxLength(50).IsRequired();
            builder.Property(e => e.Username).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Email).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Password).HasMaxLength(400).IsRequired();
            builder.Property(e => e.Image).IsRequired(false);
            builder.Property(e => e.Biography).IsRequired(false);

            builder.HasMany(e => e.News).WithOne(e => e.User).HasForeignKey(e => e.UserId);
        }
    }
}