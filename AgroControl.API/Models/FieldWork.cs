using System.Reflection.PortableExecutable;

namespace AgroControl.API.Models
{
    public class FieldWork
    {
        public int Id { get; set; }
        public int FarmId {  get; set; }
        public int FieldId {  get; set; }
        public bool IsPlanned {  get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int? EmployeeId {  get; set; }
        public string? Description { get; set; }

        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int? DeletedBy { get; set; }

        public ICollection<FieldWorkAgriculturalEquipment> FieldWorkAgriculturalEquipment { get; set; } = new List<FieldWorkAgriculturalEquipment>();
        public required Farm Farm { get; set; }
        public required Field Field { get; set; }
        public Employee? Employee { get; set; }
    }
    public class FertilizingWork:FieldWork
    {
        public ICollection<FertilizingWorkFertilizer> FertilizingWorkFertilizers { get; set; } = new List<FertilizingWorkFertilizer>();
    }
    public class SprayingWork:FieldWork
    {
        public ICollection<SprayingWorkCropProtectionProduct> SprayingWorkCropProtectionProducts { get; set; } = new List<SprayingWorkCropProtectionProduct>();
    }
    public class HarvestingWork:FieldWork
    {
        public int TotalYield {  get; set; }
        public decimal? Moisture { get; set; }
        public int CropId { get; set; }
        public required Crop Crop { get; set; }
    }
    public class OtherWork:FieldWork
    {

    }
}
