namespace BurgerRestaurantManagement.Models.ProductModels
{
    public class ProductMiniModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int ProductTypeId { get; set; }
    }
}
