namespace AgroControl.API.Models
{
    public class FarmInventory
    {
        public int FarmId { get; set; }
        public int Quantity { get; set; }
        public decimal AverageUnitPrice { get; set; }

        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedById { get; set; }

        public Farm Farm { get; set; }
    }
    public class FarmCropProtectionProduct : FarmInventory
    {
        public int CropProtectionProductId { get; set; }
        public CropProtectionProduct CropProtectionProduct { get; set; }
    }
    public class FarmFertilizer : FarmInventory
    {
        public int FertilizerId { get; set; }
        public Fertilizer Fertilizer { get; set; }
    }
    public class FarmSeed : FarmInventory
    {
        public int SeedId { get; set; }
        public decimal SeedWeight { get; set; }
        public decimal GerminationRate { get; set; }
        public decimal Purity {  get; set; }
        public Seed Seed { get; set; }
    }
    public class FarmFuel : FarmInventory
    {
        public int FuelId { get; set; }
        public Fuel Fuel { get; set; }
    }
    public class FarmGrainSilo : FarmInventory
    {
        public int CropId { get; set; }
        public Crop Crop { get; set; }
    }
}
