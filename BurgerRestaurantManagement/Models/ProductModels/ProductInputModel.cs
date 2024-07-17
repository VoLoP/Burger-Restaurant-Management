namespace BurgerRestaurantManagement.Models.ProductModels
{
    public class ProductInputModel
    {
        public int ProductId { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int ProductTypeId { get; set; }
    }
}
