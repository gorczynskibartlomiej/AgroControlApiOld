namespace AgroControl.API.Models
{
    public class FertilizingWorkFertilizer
    {
        public int FertilizingWorkId { get; set; }
        public int FertilizerId { get; set; }
        public required FertilizingWork FertilizingWork { get; set; }
        public required Fertilizer Fertilizer { get; set; }
    }
}
