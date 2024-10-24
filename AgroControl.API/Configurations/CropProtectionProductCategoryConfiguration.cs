using AgroControl.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgroControl.API.Configurations
{
    public class CropProtectionProductCategoryConfiguration : IEntityTypeConfiguration<CropProtectionProductCategory>
    {
        public void Configure(EntityTypeBuilder<CropProtectionProductCategory> builder)
        {
            builder.ToTable("CropProtectionProductCategories");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasMany(cppc =>cppc.CropProtectionProducts)
                .WithOne(cpp => cpp.CropProtectionProductCategory)
                .HasForeignKey(cpp => cpp.CropProtectionProductCategoryId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
