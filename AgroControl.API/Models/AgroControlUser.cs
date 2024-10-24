using Microsoft.AspNetCore.Identity;

namespace AgroControl.API.Models
{
    public class AgroControlUser:IdentityUser<Guid>
    {
        public ICollection<AgriculturalEquipment> AgriculturalEquipment { get; set; }
        //public bool FirstLogin { get; set; }
    }
}
