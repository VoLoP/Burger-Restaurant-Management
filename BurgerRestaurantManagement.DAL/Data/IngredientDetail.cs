using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerRestaurantManagement.DAL.Data
{
    public class IngredientDetail
    {
        public int IngredientDetailId { get; set; }
        public int IngredientId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public Ingredient? Ingredient { get; set; }
        public Product? Product { get; set; }
    }
}
