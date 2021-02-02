using Microsoft.EntityFrameworkCore;
using miniShop.Data;
using miniShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniShop.Services
{
    public class CategoryService : ICategoryService
    {
        private miniShopDbContext dbContext;

        public CategoryService(miniShopDbContext miniShopDbContext)
        {
            this.dbContext = miniShopDbContext;
        }
        public IList<Category> GetCategories() => dbContext.Categories.AsNoTracking().ToList();
    }
}
