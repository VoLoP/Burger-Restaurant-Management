using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerRestaurantManagement.DAL.Data
{
    public class Cart
    {
        public int CartId { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
