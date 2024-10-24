namespace AgroControl.API.Models
{
    public class Crop
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<CropProtectionProductCrop> CropProtectionProductCrops { get; set; }  
        public ICollection<FarmGrainSilo> FarmGrainSilos { get; set; }
        public ICollection<Seed> Seeds { get; set; }
        public ICollection<CropRotationPlanner> CropRotationPlanners { get; set; }
    }
}
