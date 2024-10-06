using BurgerRestaurantManagement.DAL.Data;
using BurgerRestaurantManagement.Models.IngredientDetailModels;
using BurgerRestaurantManagement.Models.IngredientModels;
using BurgerRestaurantManagement.Models.OrderDetailModels;
using BurgerRestaurantManagement.Models.OrderModels;
using BurgerRestaurantManagement.Models.ProductModels;
using BurgerRestaurantManagement.Models.TagModels;

namespace BurgerRestaurantManagement.Models
{
    public class Mapper
    {
        #region Ingredient
        public static IngredientOutputModel MapEntityToModel(Ingredient ingredient)
        {
            return new IngredientOutputModel
            {
                IngredientId = ingredient.IngredientId,
                Name = ingredient.Name,
                Description = ingredient.Description,
                Price = ingredient.Price,
                Products = ingredient.Products?.Select(MapEntityToMiniModel).ToList(),
                IngredientDetails = ingredient.IngredientDetails?.Select(MapEntityToMiniModel).ToList()
            };
        }

        public static Ingredient MapModelToEntity(IngredientInputModel ingredientInputModel)
        {
            return new Ingredient
            {
                IngredientId = ingredientInputModel.IngredientId,
                Name = ingredientInputModel.Name,
                Description = ingredientInputModel.Description,
                Price = ingredientInputModel.Price
            };
        }
        #endregion

        #region IngredientDetail
        public static IngredientDetailMiniModel MapEntityToMiniModel(IngredientDetail ingredientDetail)
        {
            return new IngredientDetailMiniModel
            {
                IngredientId = ingredientDetail.IngredientId,
                ProductId = ingredientDetail.ProductId,
                Amount = ingredientDetail.Amount
            };
        }
        #endregion

        #region Product
        public static ProductOutputModel MapEntityToModel(Product product)
        {
            return new ProductOutputModel
            {
                ProductId = product.ProductId,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                ProductTypeId = product.ProductTypeId,
                IngredientDetails = product.IngredientDetails?.Select(MapEntityToMiniModel).ToList(),
                Tags = product.Tags?.Select(MapEntityToMiniModel).ToList(),
                OrderDetails = product.OrderDetails?.Select(MapEntityToMiniModel).ToList()
            };
        }

        public static Product MapModelToEntity(ProductInputModel productInputModel)
        {
            return new Product
            {
                ProductId = productInputModel.ProductId,
                Name = productInputModel.Name,
                Description = productInputModel.Description,
                Price = productInputModel.Price,
                ProductTypeId = productInputModel.ProductTypeId
            };
        }

        public static ProductMiniModel MapEntityToMiniModel(Product product)
        {
            return new ProductMiniModel
            {
                ProductId = product.ProductId,
                Name = product.Name,
                Price = product.Price,
                ProductTypeId = product.ProductTypeId
            };
        }
        #endregion

        #region Tag
        public static TagMiniModel MapEntityToMiniModel(Tag tag)
        {
            return new TagMiniModel
            {
                TagId = tag.TagId,
                Name = tag.Name
            };
        }

        #endregion

        #region OrderDetail
        public static OrderDetailMiniModel MapEntityToMiniModel(OrderDetail orderDetail)
        {
            return new OrderDetailMiniModel
            {
                OrderId = orderDetail.OrderId,
                ProductId = orderDetail.ProductId,
                Amount = orderDetail.Amount
            };
        }

        #endregion
    
        #region ProductType
        public ProductType MapModelToEntity(ProductTypeInputModel productTypeInputModel)
        {
            return new ProductType
            {
                ProductTypeId = productTypeInputModel.ProductTypeId,
                Name = productTypeInputModel.Name
            };
        }
        #endregion
    
        #region Order
        public Order MapModelToEntity(OrderInputModel orderInputModel)
        {
            return new Order
            {
                OrderId = orderInputModel.OrderId,
                OrderDate = orderInputModel.OrderDate,
                OrderCode = orderInputModel.OrderCode,
                TotalAmount = orderInputModel.TotalAmount,
                UserId = orderInputModel.UserId
            };
        }

        public OrderOutputModel MapEntityToModel(Order order)
        {
            return new OrderOutputModel
            {
                OrderId = order.OrderId,
                OrderDate = order.OrderDate,
                OrderCode = order.OrderCode,
                TotalAmount = order.TotalAmount,
                UserId = order.UserId,
                OrderDetails = order.OrderDetails?.Select(MapEntityToMiniModel).ToList()
            };
        }
        #endregion
    }
}
