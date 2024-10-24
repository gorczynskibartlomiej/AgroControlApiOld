namespace AgroControl.API.Models
{
    public class Seed
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Variety { get; set; }
        public int CropId { get; set; }
        public int UnitId { get; set; }
        public int ProducerId { get; set; }
        public string? Description { get; set; }
        public required Crop Crop { get; set; }
        public required Unit Unit { get; set; }
        public required Producer Producer { get; set; }
    }
}
