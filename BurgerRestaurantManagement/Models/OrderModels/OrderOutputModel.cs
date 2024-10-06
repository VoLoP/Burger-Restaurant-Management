using BurgerRestaurantManagement.DAL.Data;
using BurgerRestaurantManagement.Models.OrderDetailModels;

namespace BurgerRestaurantManagement.Models.OrderModels
{
    public class OrderOutputModel
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public required string OrderCode { get; set; }
        public decimal TotalAmount { get; set; }
        public string? UserId { get; set; }
        public List<OrderDetailMiniModel>? OrderDetails { get; set; }
    }
}
