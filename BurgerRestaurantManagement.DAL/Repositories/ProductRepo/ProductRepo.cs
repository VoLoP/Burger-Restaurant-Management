using BurgerRestaurantManagement.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerRestaurantManagement.DAL.Repositories.ProductRepo
{
    public class ProductRepo : IProductRepo
    {
        public Task<Product> AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<Product> DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
