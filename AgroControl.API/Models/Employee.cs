using Microsoft.AspNetCore.Identity;

namespace AgroControl.API.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public Guid? UserId { get; set; }
        public Guid? RoleId { get; set; }
        public int FarmId { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public int CostUnitId { get; set; }
        public decimal Cost {  get; set; }
        public bool IsActive { get; set; }

        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int? DeletedBy { get; set; }

        public required CostUnit CostUnit { get; set; }
        public required Farm Farm { get; set; }
        public required AgroControlUser AgroControlUser { get; set; }
        public required IdentityRole Role { get; set; }
    }
}
