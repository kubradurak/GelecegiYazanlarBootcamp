using miniShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniShop.Services
{
    public class FakeUserService : IUserService
    {
        private List<User> users = new List<User>
        {
            new User{ UserName = "kub", Name="Kübra" ,Password="123456"},
            new User{ UserName = "turkay", Name="Turkay", Password="987" }
        };

        public User ValidUser(string username, string password)
        {
            return users.FirstOrDefault(u => u.UserName == username && u.Password == password);
        }

    }
}
