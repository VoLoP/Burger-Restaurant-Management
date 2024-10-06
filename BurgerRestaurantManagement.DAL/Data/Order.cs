using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerRestaurantManagement.DAL.Data
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public required string OrderCode { get; set; }
        public decimal TotalAmount { get; set; }
        public string? UserId { get; set; }
        public User? User { get; set; }
        public List<OrderDetail>? OrderDetails { get; set; }
    }
}
