namespace AgroControl.API.Models
{
    public class Field
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int FarmId { get; set; }
        //public Polygon Polygon {  get; set; }
        //dorobic informacje!!!
        public decimal Area { get; set; }

        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int? DeletedBy { get; set; }

        public Farm Farm { get; set; }
        
    }
}
