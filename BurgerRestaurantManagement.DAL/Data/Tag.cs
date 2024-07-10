using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerRestaurantManagement.DAL.Data
{
    public class Tag
    {
        public int TagId { get; set; }
        public required string Name { get; set; }
        public List<Product>? Products { get; set; }
    }
}
