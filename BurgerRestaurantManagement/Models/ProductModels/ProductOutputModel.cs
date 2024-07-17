using BurgerRestaurantManagement.DAL.Data;

namespace BurgerRestaurantManagement.Models.ProductModels
{
    public class ProductOutputModel
    {
        public int ProductId { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int ProductTypeId { get; set; }
        public List<IngredientDetail>? IngredientDetails { get; set; }
        public List<Tag>? Tags { get; set; }
        public List<OrderDetail>? OrderDetails { get; set; }
    }
}
