using BurgerRestaurantManagement.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerRestaurantManagement.DAL.Repositories.OrderRepo
{
    public class OrderRepo : IOrderRepo
    {
        public Task<Order> AddOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public Task<Order> DeleteOrder(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Order>> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetOrderById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Order> UpdateOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
