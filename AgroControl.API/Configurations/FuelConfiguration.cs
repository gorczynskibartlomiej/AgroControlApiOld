using AgroControl.API.Constans;
using AgroControl.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgroControl.API.Configurations
{
    public class FuelConfiguration : IEntityTypeConfiguration<Fuel>
    {
        public void Configure(EntityTypeBuilder<Fuel> builder)
        {
            builder.ToTable("Fuels");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(Options.NameLength);

            builder.Property(x => x.FuelSymbol)
                .HasMaxLength(Options.FuelSymbolLength);
            
            builder.HasMany(f =>f.AgriculturalEquipment)
                .WithOne(ae => ae.Fuel)
                .HasForeignKey(ae => ae.FuelId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
