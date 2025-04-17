using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagementSystem.Entity
{
    public class Users
    {
        public int UserId {  get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public Users()
        {
            
        }
        public Users(int userId,string userName,string uPassword,string uRole)
        {
            UserId = userId;
            UserName = userName;
            Password = uPassword;
            Role = uRole;
        }
    }
}
