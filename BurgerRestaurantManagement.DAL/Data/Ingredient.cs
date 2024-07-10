using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerRestaurantManagement.DAL.Data
{
    public class Ingredient
    {
        public int IngredientId { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public List<Product>? Products { get; set; }
        public List<IngredientDetail>? IngredientDetails { get; set; }
    }
}
