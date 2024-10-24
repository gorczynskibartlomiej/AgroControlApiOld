using AgroControl.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgroControl.API.Configurations
{
    public class CropProtectionProductCropConfiguration : IEntityTypeConfiguration<CropProtectionProductCrop>
    {
        public void Configure(EntityTypeBuilder<CropProtectionProductCrop> builder)
        {
            builder.ToTable("CropProtectionProductCrops");

            builder.HasKey(x => new { x.CropProtectionProductId, x.CropId });
        }
    }
}
