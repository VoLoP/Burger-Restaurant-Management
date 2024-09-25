using BurgerRestaurantManagement.DAL.Repositories.IngredientRepo;
using BurgerRestaurantManagement.DAL.Repositories.UserRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BurgerRestaurantManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepo _userRepo;

        public UserController(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }
    }
}
