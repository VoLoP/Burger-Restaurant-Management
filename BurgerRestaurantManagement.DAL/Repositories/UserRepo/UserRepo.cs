using BurgerRestaurantManagement.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerRestaurantManagement.DAL.Repositories.UserRepo
{
    public class UserRepo : IUserRepo
    {
        public Task<User> AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task<User> DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
