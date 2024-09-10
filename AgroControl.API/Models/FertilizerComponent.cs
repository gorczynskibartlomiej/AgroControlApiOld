namespace AgroControl.API.Models
{
    public class FertilizerComponent
    {
        public int FertilizerId { get; set; }
        public int ChemicalElementId { get; set; }
        public decimal ElementPercentage { get; set; }

        public Fertilizer Fertilizer { get; set; }
        public ChemicalElement ChemicalElement { get; set; }
    }
    
}
