using AgroControl.API.Constans;
using AgroControl.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgroControl.API.Configurations
{
    public class FieldWorkConfiguration : IEntityTypeConfiguration<FieldWork>,
                                            IEntityTypeConfiguration<FertilizingWork>,
                                            IEntityTypeConfiguration<SprayingWork>,
                                            IEntityTypeConfiguration<HarvestingWork>,
                                            IEntityTypeConfiguration<OtherWork>

    {
        public void Configure(EntityTypeBuilder<FieldWork> builder)
        {
            builder.HasKey(fw => fw.Id);

            builder.Property(fw => fw.FarmId)
                .IsRequired();

            builder.Property(fw => fw.FieldId)
                .IsRequired();

            builder.Property(fw => fw.IsPlanned)
                .IsRequired();

            builder.Property(fw => fw.EmployeeId)//zastanowic sie co tu dac??????//
                .IsRequired();

            builder.Property(fw => fw.Description)
                .HasMaxLength(Options.DescriptionLength);


            builder.Property(fw => fw.CreatedOn)
                .IsRequired();

            builder.Property(fw => fw.CreatedBy)
                .IsRequired();

            builder.Property(fw => fw.UpdatedOn)
                .IsRequired();

            builder.Property(fw => fw.UpdatedBy)
                .IsRequired();

            builder.HasMany(fw => fw.FieldWorkAgriculturalEquipment)
                .WithOne(fwae => fwae.FieldWork)
                .HasForeignKey(fwae => fwae.FieldWorkId)
                .OnDelete(DeleteBehavior.Cascade);
        }

        public void Configure(EntityTypeBuilder<FertilizingWork> builder)
        {
            throw new NotImplementedException();
        }

        public void Configure(EntityTypeBuilder<SprayingWork> builder)
        {
            throw new NotImplementedException();
        }

        public void Configure(EntityTypeBuilder<HarvestingWork> builder)
        {
            throw new NotImplementedException();
        }

        public void Configure(EntityTypeBuilder<OtherWork> builder)
        {
            throw new NotImplementedException();
        }
    }
}
