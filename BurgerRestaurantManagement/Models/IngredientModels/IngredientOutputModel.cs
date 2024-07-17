using BurgerRestaurantManagement.Models.IngredientDetailModels;
using BurgerRestaurantManagement.Models.ProductModels;

namespace BurgerRestaurantManagement.Models.IngredientModels
{
    public class IngredientOutputModel
    {
        public int IngredientId { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public List<ProductMiniModel>? Products { get; set; }
        public List<IngredientDetailMiniModel>? IngredientDetails { get; set; }
    }
}
