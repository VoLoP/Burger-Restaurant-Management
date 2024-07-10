using BurgerRestaurantManagement.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerRestaurantManagement.DAL.Repositories.OrderRepo
{
    public interface IOrderRepo
    {
        Task<IEnumerable<Order>> GetAllOrders();
        Task<Order> GetOrderById(int id);
        Task<Order> AddOrder(Order order);
        Task<Order> UpdateOrder(Order order);
        Task<Order> DeleteOrder(int id);
    }
}
