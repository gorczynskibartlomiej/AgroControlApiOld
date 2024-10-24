namespace AgroControl.API.Models
{
    public class FarmInventory
    {
        public int FarmId { get; set; }
        public int Quantity { get; set; }
        public decimal AverageUnitPrice { get; set; }
//unit? - nie ma w fuel, i crop
//silos oddzielnie
//co z pojemnoscia opakowan(nasiona?)
//ogolne id zmienic!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int? DeletedBy { get; set; }

        public required Farm Farm { get; set; }
    }
    public class FarmCropProtectionProduct : FarmInventory
    {
        public int CropProtectionProductId { get; set; }
        public required CropProtectionProduct CropProtectionProduct { get; set; }
    }
    public class FarmFertilizer : FarmInventory
    {
        public int FertilizerId { get; set; }
        public required Fertilizer Fertilizer { get; set; }
    }
    public class FarmSeed : FarmInventory
    {
        public int SeedId { get; set; }
        public decimal SeedWeight { get; set; }
        public decimal GerminationRate { get; set; }
        public decimal Purity {  get; set; }
        public required Seed Seed { get; set; }
    }
    public class FarmFuel : FarmInventory
    {
        public int FuelId { get; set; }
        public required Fuel Fuel { get; set; }
    }
    public class FarmGrainSilo : FarmInventory
    {
        public int CropId { get; set; }
        public required Crop Crop { get; set; }
    }
}
