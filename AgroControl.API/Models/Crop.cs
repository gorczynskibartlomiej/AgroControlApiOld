namespace AgroControl.API.Models
{
    public class Crop
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<CropProtectionProductCrop> CropProtectionProductCrops { get; set; }  
    }
}
