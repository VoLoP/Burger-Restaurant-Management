using BurgerRestaurantManagement.DAL.Repositories.IngredientRepo;
using BurgerRestaurantManagement.Models;
using BurgerRestaurantManagement.Models.IngredientModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<IngredientOutputModel>>> GetAllIngredients()
        {
            var ingredients = await _ingredientRepo.GetAll();
            var ingredientModels = ingredients.Select(Mapper.MapEntityToModel).ToList();
            return Ok(ingredientModels);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IngredientOutputModel>> GetIngredientById(int id)
        {
            var ingredient = await _ingredientRepo.GetById(id);
            if (ingredient == null)
            {
                return NotFound();
            }
            var ingredientModel = Mapper.MapEntityToModel(ingredient);
            return Ok(ingredientModel);
        }

        [HttpPost]
        public async Task<ActionResult<IngredientOutputModel>> AddIngredient(IngredientInputModel ingredientInputModel)
        {
            var ingredient = Mapper.MapModelToEntity(ingredientInputModel);
            var addedIngredient = await _ingredientRepo.Add(ingredient);
            var ingredientModel = Mapper.MapEntityToModel(addedIngredient);
            return CreatedAtAction(nameof(GetIngredientById), new { id = ingredientModel.IngredientId }, ingredientModel);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<IngredientOutputModel>> UpdateIngredient(int id, IngredientInputModel ingredientInputModel)
        {
            if (id != ingredientInputModel.IngredientId)
            {
                return BadRequest();
            }

            var ingredient = Mapper.MapModelToEntity(ingredientInputModel);
            var updatedIngredient = await _ingredientRepo.Update(ingredient);
            var ingredientModel = Mapper.MapEntityToModel(updatedIngredient);
            return Ok(ingredientModel);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<IngredientOutputModel>> DeleteIngredient(int id)
        {
            var deletedIngredient = await _ingredientRepo.Delete(id);
            if (deletedIngredient == null)
            {
                return NotFound();
            }
            var ingredientModel = Mapper.MapEntityToModel(deletedIngredient);
            return Ok(ingredientModel);
        }
    }
}