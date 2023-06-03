using Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistance.Configurations.Base;

namespace Persistance.Configurations
{
    public class UserSocialConfiguration : BaseConfiguration<UserSocial>
    {
        public override void Configure(EntityTypeBuilder<UserSocial> builder)
        {
            base.Configure(builder);
            builder.Property(e => e.Facebook).HasMaxLength(500).IsRequired(false);
            builder.Property(e => e.Github).HasMaxLength(500).IsRequired(false);
            builder.Property(e => e.Instagram).HasMaxLength(500).IsRequired(false);
            builder.Property(e => e.Linkedin).HasMaxLength(500).IsRequired(false);
            builder.Property(e => e.Medium).HasMaxLength(500).IsRequired(false);
            builder.Property(e => e.Twitter).HasMaxLength(500).IsRequired(false);
            builder.Property(e => e.Youtube).HasMaxLength(500).IsRequired(false);

            builder.HasOne(e => e.User).WithOne(e => e.UserSocial).HasForeignKey<UserSocial>(e => e.UserId);
        }
    }
}