using miniShop.Data;
using miniShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniShop.Services
{
    public class UserService : IUserService
    {
        private miniShopDbContext dbContext;

        public UserService(miniShopDbContext miniShopDbContext)
        {
            this.dbContext = miniShopDbContext;

        }
        public User ValidUser(string username, string password)
        {
            return dbContext.Users.FirstOrDefault(u => u.UserName == username && u.Password == password);
        }
    }
}
