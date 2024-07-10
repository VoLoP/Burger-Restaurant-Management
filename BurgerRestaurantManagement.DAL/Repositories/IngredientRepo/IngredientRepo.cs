using BurgerRestaurantManagement.DAL.Data;
using BurgerRestaurantManagement.DAL.Repositories.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerRestaurantManagement.DAL.Repositories.IngredientRepo
{
    public class IngredientRepo(BurgerDbContext ctx) : GenericRepo<Ingredient>(ctx), IIngredientRepo
    {
        
    }
}
