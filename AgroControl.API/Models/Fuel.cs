namespace AgroControl.API.Models
{
    public class Fuel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? FuelSymbol {  get; set; }

        public ICollection<AgriculturalEquipment> AgriculturalEquipment { get; set; } = new List<AgriculturalEquipment>();
    }
}
