using AgroControl.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AgroControl.API.Constans;

namespace AgroControl.API.Configurations;

public class CropRotationPlannerConfiguration : IEntityTypeConfiguration<CropRotationPlanner>
{
    public void Configure(EntityTypeBuilder<CropRotationPlanner> builder)
    {
        builder.ToTable("CropRotationPlanner");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.FarmId)
            .IsRequired();

        builder.Property(x => x.FieldId)
            .IsRequired();

        builder.Property(x => x.CropId)
            .IsRequired();

        builder.Property(x => x.Description)
            .HasMaxLength(Options.DescriptionLength);

        builder.Property(x => x.Year)
            .IsRequired();


        builder.Property(x => x.CreatedOn)
                .IsRequired();

        builder.Property(x => x.CreatedBy)
            .IsRequired();

        builder.Property(x => x.UpdatedOn)
            .IsRequired();

        builder.Property(x => x.UpdatedBy)
            .IsRequired();
    }
}
