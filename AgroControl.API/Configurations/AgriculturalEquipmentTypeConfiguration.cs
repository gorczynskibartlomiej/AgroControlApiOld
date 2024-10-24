using AgroControl.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgroControl.API.Configurations
{
    public class AgriculturalEquipmentTypeConfiguration : IEntityTypeConfiguration<AgriculturalEquipmentType>
    {
        public void Configure(EntityTypeBuilder<AgriculturalEquipmentType> builder)
        {
            builder.ToTable("AgriculturalEquipmentTypes");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasMany(aet => aet.AgriculturalEquipment)
                .WithOne(ae => ae.AgriculturalEquipmentType)
                .HasForeignKey(ae => ae.AgriculturalEquipmentTypeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
