using AgroControl.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgroControl.API.Configurations
{
    public class ActiveIngredientConfiguration : IEntityTypeConfiguration<ActiveIngredient>
    {
        public void Configure(EntityTypeBuilder<ActiveIngredient> builder)
        {
            builder.ToTable("ActiveIngredients");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired();

        }
    }
}
