using BurgerRestaurantManagement.DAL.Data;
using BurgerRestaurantManagement.Models.IngredientDetailModels;
using BurgerRestaurantManagement.Models.OrderDetailModels;
using BurgerRestaurantManagement.Models.TagModels;

namespace BurgerRestaurantManagement.Models.ProductModels
{
    public class ProductOutputModel
    {
        public int ProductId { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int ProductTypeId { get; set; }
        public List<IngredientDetailMiniModel>? IngredientDetails { get; set; }
        public List<TagMiniModel>? Tags { get; set; }
        public List<OrderDetailMiniModel>? OrderDetails { get; set; }
    }
}
