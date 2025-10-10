using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configrations
{
    internal class AppUserConfigration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(c => c.Name)
                  .HasMaxLength(200);

            builder.Property(c => c.RefreshToken)
                .HasMaxLength(2000)
                .IsRequired(false);

            builder.HasIndex(u => u.Email)
                .IsUnique();
        }
    }
}
