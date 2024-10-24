using AgroControl.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgroControl.API.Configurations
{
    public class SprayingWorkCropProtectionProductConfiguration : IEntityTypeConfiguration<SprayingWorkCropProtectionProduct>
    {
        public void Configure(EntityTypeBuilder<SprayingWorkCropProtectionProduct> builder)
        {
            builder.ToTable("SprayingWorkCropProtectionProducts");

            builder.HasKey(x => new {x.SprayingWorkId,x.CropProtectionProductId});

            builder.Property(x => x.Quantity)
                .IsRequired();
        }
    }
}
