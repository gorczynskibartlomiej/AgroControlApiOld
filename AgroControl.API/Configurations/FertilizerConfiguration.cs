using AgroControl.API.Constans;
using AgroControl.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgroControl.API.Configurations
{
    public class FertilizerConfiguration : IEntityTypeConfiguration<Fertilizer>
    {
        public void Configure(EntityTypeBuilder<Fertilizer> builder)
        {
            builder.ToTable("Fertilizers");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(Options.NameLength);

            builder.Property(x => x.Description)
                .HasMaxLength(Options.DescriptionLength);

            builder.Property(x => x.ProducerId)
                .IsRequired();

            builder.Property(x => x.UnitId)
                .IsRequired();

            builder.HasMany(f => f.FertilizerComponents)
                .WithOne(fc => fc.Fertilizer)
                .HasForeignKey(fc => fc.FertilizerId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
