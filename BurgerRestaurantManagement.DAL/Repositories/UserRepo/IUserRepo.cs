using BurgerRestaurantManagement.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerRestaurantManagement.DAL.Repositories.UserRepo
{
    public interface IUserRepo
    {
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetUserById(int id);
        Task<User> AddUser(User user);
        Task<User> UpdateUser(User user);
        Task<User> DeleteUser(int id);
    }
}
