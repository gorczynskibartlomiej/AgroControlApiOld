using AgroControl.API.Constans;
using AgroControl.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgroControl.API.Configurations
{
    public class FarmInventoryConfiguration : IEntityTypeConfiguration<FarmInventory>,
                                                IEntityTypeConfiguration<FarmCropProtectionProduct>,
                                                IEntityTypeConfiguration<FarmFertilizer>,
                                                IEntityTypeConfiguration<FarmSeed>,
                                                IEntityTypeConfiguration<FarmFuel>,
                                                IEntityTypeConfiguration<FarmGrainSilo>

    {
        public void Configure(EntityTypeBuilder<FarmInventory> builder)
        {
            builder.Property(fi => fi.FarmId)
                .IsRequired();

            builder.Property(fi => fi.Quantity)
                .IsRequired();

            builder.Property(fi => fi.AverageUnitPrice)
                .HasPrecision(Options.StandardPrecision,Options.StandardScale)
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

        public void Configure(EntityTypeBuilder<FarmCropProtectionProduct> builder)
        {
            builder.ToTable("FarmCropProtectionProducts");

            builder.HasKey(fcpp => new { fcpp.FarmId, fcpp.CropProtectionProductId });
        }

        public void Configure(EntityTypeBuilder<FarmFertilizer> builder)
        {
            builder.ToTable("FarmFertilizers");

            builder.HasKey(ff => new { ff.FarmId, ff.FertilizerId });
        }

        public void Configure(EntityTypeBuilder<FarmSeed> builder)
        {
            throw new NotImplementedException();
        }

        public void Configure(EntityTypeBuilder<FarmFuel> builder)
        {
            builder.ToTable("FarmFuel");

            builder.HasKey(ff => new { ff.FarmId, ff.FuelId });
        }

        public void Configure(EntityTypeBuilder<FarmGrainSilo> builder)
        {
            
        }
    }
}
