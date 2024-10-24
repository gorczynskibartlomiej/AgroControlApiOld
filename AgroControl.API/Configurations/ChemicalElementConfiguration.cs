using AgroControl.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgroControl.API.Configurations
{
    public class ChemicalElementConfiguration : IEntityTypeConfiguration<ChemicalElement>
    {
        public void Configure(EntityTypeBuilder<ChemicalElement> builder)
        {
            builder.ToTable("ChemicalElements");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.ChemicalSymbol)
                .IsRequired()
                .HasMaxLength(2);
            
            builder.HasMany(ce => ce.FertilizerComponents)
                .WithOne(fc => fc.ChemicalElement)
                .HasForeignKey(fc => fc.ChemicalElementId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
