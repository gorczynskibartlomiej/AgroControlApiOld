using AgroControl.API.Constans;
using AgroControl.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgroControl.API.Configurations
{
    public class FertilizerComponentConfiguration : IEntityTypeConfiguration<FertilizerComponent>
    {
        public void Configure(EntityTypeBuilder<FertilizerComponent> builder)
        {
            builder.ToTable("FertilizerComponents");

            builder.HasKey(x => new { x.FertilizerId, x.ChemicalElementId });

            builder.Property(x => x.ElementPercentage)
                .IsRequired()
                .HasPrecision(Options.DataPrecision, Options.DataScale);
        }
    }
}
