using AgroControl.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgroControl.API.Configurations
{
    public class FertilizingWorkFertilizerConfiguration : IEntityTypeConfiguration<FertilizingWorkFertilizer>
    {
        public void Configure(EntityTypeBuilder<FertilizingWorkFertilizer> builder)
        {
            builder.ToTable("FertilizingWorkFertilizers");

            builder.HasKey(x => new { x.FertilizingWorkId, x.FertilizerId });
        }
    }
}
