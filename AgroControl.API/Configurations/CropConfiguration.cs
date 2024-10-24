using AgroControl.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgroControl.API.Configurations
{
    public class CropConfiguration : IEntityTypeConfiguration<Crop>
    {
        public void Configure(EntityTypeBuilder<Crop> builder)
        {
            builder.ToTable("Crops");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasMany(c => c.CropProtectionProductCrops)
                .WithOne(cpcp => cpcp.Crop)
                .HasForeignKey(cpcp => cpcp.CropId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(c => c.FarmGrainSilos)
                .WithOne(fi => fi.Crop)
                .HasForeignKey(fi => fi.CropId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(c => c.Seeds)
                .WithOne(s => s.Crop)
                .HasForeignKey(s => s.CropId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(c => c.CropRotationPlanners)
                .WithOne(crp => crp.Crop)
                .HasForeignKey(crp => crp.CropId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
