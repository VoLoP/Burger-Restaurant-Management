using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerRestaurantManagement.DAL.Data
{
    public class StaffMember
    {
        public int StaffMemberId { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int Salary { get; set; }
    }
}
