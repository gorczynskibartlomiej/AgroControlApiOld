namespace AgroControl.API.Models
{
    public class FertilizingWorkFertilizer
    {
        public int FertilizingWorkId { get; set; }
        public int FertilizerId { get; set; }
        public FertilizingWork FertilizingWork { get; set; }
        public Fertilizer Fertilizer { get; set; }
    }
}
