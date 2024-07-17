namespace BurgerRestaurantManagement.Models.IngredientModels
{
    public class IngredientInputModel
    {
        public int IngredientId { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
    }
}
