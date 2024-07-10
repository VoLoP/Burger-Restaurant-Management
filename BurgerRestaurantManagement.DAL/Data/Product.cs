using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerRestaurantManagement.DAL.Data
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int ProductTypeId { get; set; }
        public List<IngredientDetail>? IngredientDetails { get; set; }
        public List<Tag>? Tags { get; set; }
        public List<OrderDetail>? OrderDetails { get; set; }
        public ProductType? ProductType { get; set; }
    }
}
