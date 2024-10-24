using AgroControl.API.Constans;
using AgroControl.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgroControl.API.Configurations
{
    public class CropProtectionProductConfiguration : IEntityTypeConfiguration<CropProtectionProduct>
    {
        public void Configure(EntityTypeBuilder<CropProtectionProduct> builder)
        {
            builder.ToTable("CropProtectionProducts");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.ProducerId)
                .IsRequired();

            builder.Property(x => x.CropProtectionProductCategoryId)
                .IsRequired();

            builder.Property(x => x.UnitId)
                .IsRequired();

            builder.Property(x => x.Description)
            .HasMaxLength(Options.DescriptionLength);

            builder.HasMany(cpp => cpp.CropProtectionProductCrops)
                .WithOne(cppc => cppc.CropProtectionProduct)
                .HasForeignKey(cppc => cppc.CropProtectionProductId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(cpp => cpp.CropProtectionProductComponents)
                .WithOne(cppc => cppc.CropProtectionProduct)
                .HasForeignKey(cppc => cppc.CropProtectionProductId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(cpp => cpp.SprayingWorkCropProtectionProducts)
                .WithOne(spcpp => spcpp.CropProtectionProduct)
                .HasForeignKey(spcpp => spcpp.CropProtectionProductId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
