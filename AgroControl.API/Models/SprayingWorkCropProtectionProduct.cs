namespace AgroControl.API.Models
{
    public class SprayingWorkCropProtectionProduct
    {
        public int SprayingWorkId { get; set; }
        public int CropProtectionProductId { get; set; }
        public decimal Quantity { get; set; }
        public SprayingWork SprayingWork { get; set; }
        public CropProtectionProduct CropProtectionProduct { get; set; }
    }
}
