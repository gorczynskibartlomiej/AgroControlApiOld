namespace AgroControl.API.Models
{
    public class CropProtectionProductCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<CropProtectionProduct> CropProtectionProducts { get; set; }
    }
}
