using AgroControl.API.Constans;
using AgroControl.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgroControl.API.Configurations
{
    public class FieldConfiguration : IEntityTypeConfiguration<Field>
    {
        public void Configure(EntityTypeBuilder<Field> builder)
        {
            builder.ToTable("Fields");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(Options.NameLength);

            builder.Property(x => x.Area)
                .HasPrecision(Options.DataPrecision, Options.DataScale);
//reszta wlasciwosci, ktore zostana dodane

            builder.Property(p => p.CreatedOn)
                .IsRequired();

            builder.Property(p => p.CreatedBy)
                .IsRequired();

            builder.Property(p => p.UpdatedOn)
                .IsRequired();

            builder.Property(p => p.UpdatedBy)
                .IsRequired();
        }
    }
}
