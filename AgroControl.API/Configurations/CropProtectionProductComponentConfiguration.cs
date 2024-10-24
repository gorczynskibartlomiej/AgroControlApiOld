using AgroControl.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgroControl.API.Configurations
{
    public class CropProtectionProductComponentConfiguration : IEntityTypeConfiguration<CropProtectionProductComponent>
    {
        public void Configure(EntityTypeBuilder<CropProtectionProductComponent> builder)
        {
            builder.ToTable("CropProtectionProductComponents");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.CropProtectionProductId)
                .IsRequired();

            builder.Property(x => x.ActiveIngredientId)
                .IsRequired();

            builder.Property(x => x.Concentration)
                .IsRequired();
        }
    }
}
