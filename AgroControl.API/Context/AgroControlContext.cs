using AgroControl.API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AgroControl.API.Context
{
    public class AgroControlContext:IdentityDbContext<AgroControlUser>
    {
        public AgroControlContext(DbContextOptions<AgroControlContext> options):base(options) 
        {

        }
        public DbSet<ActiveIngredient> ActiveIngredients { get; set; }
        public DbSet<AgriculturalEquipment> AgriculturalEquipment { get; set; }
        public DbSet<AgriculturalEquipmentType> AgriculturalEquipmentTypes { get; set; }
        public DbSet<ChemicalElement> ChemicalElements { get; set; }
        public DbSet<CostUnit> CostUnits { get; set; }
        public DbSet<Crop> Crops { get; set; }
        public DbSet<CropProtectionProduct> CropProtectionProducts { get; set; }
        public DbSet<CropProtectionProductCategory> CropProtectionProductsCategories { get; set; }
        public DbSet<CropProtectionProductComponent> CropProtectionProductComponents { get; set; }
        public DbSet<CropProtectionProductCrop> CropProtectionProductCrops { get; set; }
        public DbSet<CropRotationPlanner> CropRotationPlanners { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Farm> Farms { get; set; }
        public DbSet<FarmInventory> FarmInventories { get; set; }
        public DbSet<Fertilizer> Fertilizers { get; set; }
        public DbSet<FertilizerComponent> FertilizerComponents { get; set ; }
        public DbSet<FertilizingWorkFertilizer> FertilizingWorkFertilizers { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<FieldWork> FieldWorks { get; set; }
        public DbSet<FieldWorkAgriculturalEquipment> FieldWorkAgriculturalEquipment { get; set; }
        public DbSet<Fuel> Fuels { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Seed> Seeds { get; set; }
        public DbSet<SprayingWorkCropProtectionProduct> SprayingWorkCropProtectionProducts { get; set; }
        public DbSet<Unit> Units { get; set; }
    }
}
