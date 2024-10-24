using AgroControl.API.Constans;
using AgroControl.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgroControl.API.Configurations
{
    public class AgriculturalEquipmentConfiguration : IEntityTypeConfiguration<AgriculturalEquipment>
    {
        public void Configure(EntityTypeBuilder<AgriculturalEquipment> builder)
        {
            builder.ToTable("AgriculturalEquipment");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.FarmId)
                .IsRequired();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x=>x.Brand) 
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.IsActive)
                .IsRequired();

            builder.Property(x => x.Width)
                .HasPrecision(9, 2);

            builder.Property(x => x.Height)
                .HasPrecision(9, 2);

            builder.Property(x => x.WorkingSpeed)
                .HasPrecision(9, 2);

            builder.Property(x => x.TransportSpeed)
                .HasPrecision(9, 2);

            builder.Property(x => x.WorkingWidth)
                .HasPrecision(9, 2);

            builder.Property(x => x.Cost)
                .HasPrecision(19, 2)
                .IsRequired()
                .HasDefaultValue(0);

            builder.Property(x => x.CostUnitId)
                .IsRequired();

            builder.Property(x => x.OwnerId)
                .IsRequired();

            builder.Property(x => x.AgriculturalEquipmentTypeId)
                .IsRequired();

            builder.Property(x => x.CreatedOn)
                .IsRequired();

            builder.Property(x => x.CreatedBy)
                .IsRequired();

            builder.Property(x => x.UpdatedOn)
                .IsRequired();

            builder.Property(x => x.UpdatedBy)
                .IsRequired();

            builder.Property(x => x.Description)
            .HasMaxLength(Options.DescriptionLength);
        }
    }
}
