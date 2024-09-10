namespace AgroControl.API.Models
{
    public class ChemicalElement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ChemicalSymbol { get; set; }
        public ICollection<FertilizerComponent> FertilizerComponents { get; set; }
    }
}
