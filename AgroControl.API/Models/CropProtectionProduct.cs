namespace AgroControl.API.Models
{
    public class CropProtectionProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProducerId { get; set; }
        public string? Description { get; set; }
        public int CropProtectionProductCategoryId { get; set; }
        public int UnitId { get; set; }

        public ICollection<CropProtectionProductCrop> CropProtectionProductCrops { get; set; }
        public ICollection<CropProtectionProductComponent> CropProtectionProductComponents { get; set; }
        public ICollection<SprayingWorkCropProtectionProduct> SprayingWorkCropProtectionProducts { get; set; }

        public Producer Producer { get; set; }
        public CropProtectionProductCategory CropProtectionProductCategory { get; set; }
        public Unit Unit { get; set; }

    }
}
