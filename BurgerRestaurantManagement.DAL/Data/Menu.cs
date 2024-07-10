using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerRestaurantManagement.DAL.Data
{
    public class Menu
    {
        public int MenuId { get; set; }
        public required string Name { get; set; }
        public double BasePrice { get; set; }
        public bool IsLarge { get; set; }
        public List<Product>? Products { get; set; }
    }
}
