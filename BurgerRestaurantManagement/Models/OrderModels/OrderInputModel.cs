namespace BurgerRestaurantManagement.Models.OrderModels
{
    public class OrderInputModel
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public required string OrderCode { get; set; }
        public decimal TotalAmount { get; set; }
        public string? UserId { get; set; }
    }
}
