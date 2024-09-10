namespace AgroControl.API.Models
{
    public class ActiveIngredient
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<CropProtectionProductComponent> CropProtectionProductComponents { get; set; }
    }
}
