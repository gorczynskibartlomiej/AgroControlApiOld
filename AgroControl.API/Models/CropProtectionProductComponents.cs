namespace AgroControl.API.Models
{
    public class CropProtectionProductComponent
    {
        public int Id { get; set; }
        public int CropProtectionProductId { get; set; }
        public int ActiveIngredientId { get; set; }
        public int Concentration {  get; set; }

        public CropProtectionProduct CropProtectionProduct { get; set; }
        public ActiveIngredient ActiveIngredient { get; set; }
    }
}
