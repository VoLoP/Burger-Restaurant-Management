using BurgerRestaurantManagement.DAL.Repositories.IngredientRepo;
using BurgerRestaurantManagement.DAL.Repositories.ProductRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BurgerRestaurantManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepo _productRepo;

        public ProductController(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }
    }
}
