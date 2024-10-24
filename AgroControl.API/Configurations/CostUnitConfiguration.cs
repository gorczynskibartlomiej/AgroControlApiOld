using AgroControl.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgroControl.API.Configurations
{
    public class CostUnitConfiguration : IEntityTypeConfiguration<CostUnit>
    {
        public void Configure(EntityTypeBuilder<CostUnit> builder)
        {
            builder.ToTable("CostUnits");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasMany(cu => cu.AgriculturalEquipment)
                .WithOne(ae => ae.CostUnit)
                .HasForeignKey(cu => cu.CostUnitId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
