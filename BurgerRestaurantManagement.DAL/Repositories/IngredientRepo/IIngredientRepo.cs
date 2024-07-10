using BurgerRestaurantManagement.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerRestaurantManagement.DAL.Repositories.IngredientRepo
{
    public interface IIngredientRepo
    {
        Task<IEnumerable<Ingredient>> GetAllIngredients();
        Task<Ingredient> GetIngredientById(int id);
        Task<Ingredient> AddIngredient(Ingredient ingredient);
        Task<Ingredient> UpdateIngredient(Ingredient ingredient);
        Task<Ingredient> DeleteIngredient(int id);
    }
}
