using AgroControl.API.Constans;
using AgroControl.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgroControl.API.Configurations
{
    public class PurchaseConfiguration : IEntityTypeConfiguration<Purchase>,
                                         IEntityTypeConfiguration<FertilizerPurchase>,
                                         IEntityTypeConfiguration<CropProtectionProductPurchase>,
                                         IEntityTypeConfiguration<FuelPurchase>,
                                         IEntityTypeConfiguration<SeedPurchase>
    {
        public void Configure(EntityTypeBuilder<Purchase> builder)
        {
            builder.Property(p => p.FarmId)
                .IsRequired();

            builder.Property(p => p.PurchaseDate)
                .IsRequired();

            builder.Property(p => p.PricePerUnit)
                .HasPrecision(Options.StandardPrecision, Options.StandardScale)
                .IsRequired();

            builder.Property(p => p.Description)
                .HasMaxLength(Options.DescriptionLength);

            builder.Property(p => p.SupplierName)
                .HasMaxLength(Options.NameLength);

            builder.Property(p => p.UnitId)
                .IsRequired();

            builder.Property(p => p.Quantity)
                .IsRequired();


            builder.Property(p => p.CreatedOn)
                .IsRequired();

            builder.Property(p => p.CreatedBy)
                .IsRequired();

            builder.Property(p => p.UpdatedOn)
                .IsRequired();
           
            builder.Property(p => p.UpdatedBy)
                .IsRequired();
        }
        public void Configure(EntityTypeBuilder<FertilizerPurchase> builder)
        {
            builder.ToTable("FertilizerPurchases");

            builder.HasKey(fp => fp.Id);

            builder.Property(fp => fp.FertilizerId)
                .IsRequired();
        }

        public void Configure(EntityTypeBuilder<CropProtectionProductPurchase> builder)
        {
            builder.ToTable("CropProtectionProductPurchases");

            builder.HasKey(cp => cp.Id);

            builder.Property(cp => cp.CropProtectionProductId)
                .IsRequired();
        }

        public void Configure(EntityTypeBuilder<FuelPurchase> builder)
        {
            builder.ToTable("FuelPurchases");

            builder.HasKey(fp => fp.Id);

            builder.Property(fp => fp.FuelId)
                .IsRequired();
        }

        public void Configure(EntityTypeBuilder<SeedPurchase> builder)
        {
            builder.ToTable("SeedPurchases");

            builder.HasKey(sp => sp.Id);

            builder.Property(sp => sp.SeedId)
                .IsRequired();
        }
    }
}
