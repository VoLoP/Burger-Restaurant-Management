using BurgerRestaurantManagement.DAL.Repositories.IngredientRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BurgerRestaurantManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientController : ControllerBase
    {
        private readonly IIngredientRepo _ingredientRepo;

        public IngredientController(IIngredientRepo ingredientRepo)
        {
            _ingredientRepo = ingredientRepo;
        }
    }
}
