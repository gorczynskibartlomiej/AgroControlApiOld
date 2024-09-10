namespace AgroControl.API.Models
{
    public class Fertilizer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProducerId { get; set; }
        public int UnitId {  get; set; }
        public Unit Unit { get; set; }
        public Producer Producer { get; set; }
        public ICollection<FertilizerComponent> FertilizerComponents { get; set; }
    }
}
