namespace AgroControl.API.Models
{
    public class FieldWorkAgriculturalEquipment
    {
        public int FieldWorkId { get; set; }
        public int AgriculturalEquipmentId {  get; set; }
        public decimal? FuelUsed { get; set; }
        public required FieldWork FieldWork { get; set; }
        public required AgriculturalEquipment AgriculturalEquipment { get; set; }
    }
}
