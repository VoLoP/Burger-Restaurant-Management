using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerRestaurantManagement.DAL.Data
{
    public class Role
    {
        public int RoleId { get; set; }
        public required string Name { get; set; }
        public List<User>? Users { get; set; }
    }
}
