using AgroControl.API.Constans;
using AgroControl.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgroControl.API.Configurations
{
    public class FieldWorkAgriculturalEquipmentConfiguration : IEntityTypeConfiguration<FieldWorkAgriculturalEquipment>
    {
        public void Configure(EntityTypeBuilder<FieldWorkAgriculturalEquipment> builder)
        {
            builder.ToTable("FieldWorkAgriculturalEquipment");

            builder.HasKey(x => new { x.FieldWorkId, x.AgriculturalEquipment });

            builder.Property(x => x.FuelUsed)
                .HasPrecision(Options.StandardPrecision,Options.StandardScale);
        }
    }
}
