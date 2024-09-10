namespace AgroControl.API.Models
{
    public abstract class Purchase
    {
        public int Id { get; set; } 
        public int FarmId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal PricePerUnit { get; set; }
        public string Notes { get; set; }
        public string SupplierName { get; set; }
        public string Unit { get; set; }
        public int Quantity { get; set; }

        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int? DeletedBy { get; set; }

        public Farm Farm { get; set; }
    }
    public class FertilizerPurchase : Purchase
    {
        public int FertilizerId { get; set; }
        public Fertilizer Fertilizer { get; set; }
    }
    public class CropProtectionProductPurchase : Purchase
    {
        public int CropProtectionProductId { get; set; }
        public CropProtectionProduct CropProtectionProduct { get; set; }
    }

    public class FuelPurchase : Purchase
    {
        public int FuelId { get; set; }
        public Fuel Fuel { get; set; }
    }
    public class SeedPurchase : Purchase
    {
        public int SeedId {  get; set; }
        public Seed Seed { get; set; }
    }


}
