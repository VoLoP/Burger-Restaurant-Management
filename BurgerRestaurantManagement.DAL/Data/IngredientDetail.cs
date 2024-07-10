using Microsoft.EntityFrameworkCore;

namespace BurgerRestaurantManagement.DAL.Data
{
    [PrimaryKey(nameof(IngredientId), nameof(ProductId))]
    public class IngredientDetail
    {
        public int IngredientId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public Ingredient? Ingredient { get; set; }
        public Product? Product { get; set; }
    }
}
