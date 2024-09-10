namespace AgroControl.API.Models
{
    public class AgriculturalEquipment
    {
        public int Id { get; set; }
        public int FarmId { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public bool IsActive {  get; set; }
        public int YearOfManufacture { get; set; }
        public int FuelId { get; set; }
        public int FuelCapacity { get; set; }
        public int EnginePower { get; set; }
        public int Weight { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public decimal WorkingSpeed { get; set; }
        public decimal TransportSpeed { get; set; }
        public decimal WorkingWidth { get; set; }
        public decimal Cost { get; set; }
        public int CostUnitId { get; set; }
        public DateTime LastServiceDate { get; set; }
        public DateTime NextServiceDate { get; set; }
        public int OwnerId { get; set; }
        public int AgriculturalEquipmentTypeId { get; set; }

        public DateTime CreatedOn { get; set; }
        public int CreatedById { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedById { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int? DeletedById { get; set; }

        public Fuel Fuel { get; set; }
        public AgriculturalEquipmentType AgriculturalEquipmentType { get; set; }
        public Farm Farm { get; set; }
    }
}
