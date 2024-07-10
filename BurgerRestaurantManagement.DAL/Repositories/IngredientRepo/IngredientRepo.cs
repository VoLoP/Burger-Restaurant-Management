using BurgerRestaurantManagement.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerRestaurantManagement.DAL.Repositories.IngredientRepo
{
    public class IngredientRepo : IIngredientRepo
    {
        public Task<Ingredient> AddIngredient(Ingredient ingredient)
        {
            throw new NotImplementedException();
        }

        public Task<Ingredient> DeleteIngredient(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Ingredient>> GetAllIngredients()
        {
            throw new NotImplementedException();
        }

        public Task<Ingredient> GetIngredientById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Ingredient> UpdateIngredient(Ingredient ingredient)
        {
            throw new NotImplementedException();
        }
    }
}
