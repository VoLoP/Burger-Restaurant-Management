using BurgerRestaurantManagement.DAL.Data;

namespace BurgerRestaurantManagement.Models.OrderModels
{
    public class OrderOutputModel
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public required string OrderCode { get; set; }
        public decimal TotalAmount { get; set; }
        public string? UserId { get; set; }
        public List<OrderDetail>? OrderDetails { get; set; }
    }
}
