using Microsoft.AspNetCore.Identity;

namespace AgroControl.API.Models
{
    public class AgroControlUserRole:IdentityUserRole<Guid>
    {
        public AgroControlUserRole():base()
        {
            
        }
        public int FarmId { get; set; }
        public Farm Farm { get; set; }
    }
}
