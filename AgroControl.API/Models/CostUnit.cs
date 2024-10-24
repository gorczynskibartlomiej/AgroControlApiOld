namespace AgroControl.API.Models
{
    public class CostUnit
    {
        public int Id {  get; set; }
        public string Name { get; set; }

        public ICollection<AgriculturalEquipment> AgriculturalEquipment { get; set; }

    }
}
