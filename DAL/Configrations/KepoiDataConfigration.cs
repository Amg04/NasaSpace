using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configrations
{
    internal class KepoiDataConfigration : IEntityTypeConfiguration<KepoiData>
    {
        public void Configure(EntityTypeBuilder<KepoiData> builder)
        {
            builder.HasKey(k => k.Id);

            builder.Property(k => k.kepoi_name)
             .HasMaxLength(200)
             .IsRequired();

            builder.Property(k => k.FileHash)
                 .HasMaxLength(64) 
                 .IsRequired();

            builder.HasOne(k => k.AppUser)
                 .WithMany(u => u.KepoiDataList)
                 .HasForeignKey(k => k.AppUserId)
                 .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
