using Microsoft.EntityFrameworkCore;
using miniShop.Data;
using miniShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniShop.Services
{
    public class ProductServices : IProductService
    {
        private miniShopDbContext dbContext;

        public ProductServices(miniShopDbContext miniShopDbContext)
        {
            //startup.cs belirlediğimiz 
            this.dbContext = miniShopDbContext;
        }

        public void AddProduct(Product product)
        {
            dbContext.Add(product);
            dbContext.SaveChanges();

        }

        public List<Product> GetProducts()
        {
            var products = dbContext.Products.AsNoTracking().ToList();
            return products;

        }

        public List<Product> GetProductsByCategoryId(int categoryId)
        {
            return dbContext.Products.AsNoTracking()
                .Where(p => p.CategoryId == categoryId).ToList();
        }
    }
}
