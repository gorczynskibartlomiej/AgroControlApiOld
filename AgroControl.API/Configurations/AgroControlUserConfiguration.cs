using AgroControl.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgroControl.API.Configurations
{
    public class AgroControlUserConfiguration : IEntityTypeConfiguration<AgroControlUser>
    {
        public void Configure(EntityTypeBuilder<AgroControlUser> builder)
        {
            throw new NotImplementedException();
        }
    }
}
