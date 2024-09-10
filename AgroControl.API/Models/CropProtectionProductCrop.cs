namespace AgroControl.API.Models
{
    public class CropProtectionProductCrop
    {
        public int Id { get; set; }
        public int CropProtectionproductId { get; set; }
        public int CropId { get; set; }

        public CropProtectionProduct CropProtectionProduct { get; set; }
        public Crop Crop { get; set; }
    }
}
