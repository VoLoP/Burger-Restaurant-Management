using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerRestaurantManagement.DAL.Data
{
    [PrimaryKey(nameof(OrderId), nameof(ProductId))]
    public class OrderDetail
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public Product? Product { get; set; }
        public Order? Order { get; set; }
    }
}
