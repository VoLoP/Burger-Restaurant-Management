using BurgerRestaurantManagement.DAL.Repositories.IngredientRepo;
using BurgerRestaurantManagement.DAL.Repositories.OrderRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BurgerRestaurantManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepo _orderRepo;

        public OrderController(IOrderRepo orderRepo)
        {
            _orderRepo = orderRepo;
        }
    }
}
