namespace AgroControl.API.Models
{
    public class CropRotationPlanner
    {
        public int Id { get; set; }
        public int FarmId { get; set; }
        public int FieldId {  get; set; }
        public int CropId {  get; set; }
        public string Notes {  get; set; }
        public DateOnly Year { get; set; }

        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int? DeletedBy { get; set; }

        public Farm Farm { get; set; }
        public Field Field { get; set; }
        public Crop Crop { get; set; }

    }
}
