using Microsoft.EntityFrameworkCore;
using miniShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniShop.Data
{
    public class miniShopDbContext: DbContext
    {
        public miniShopDbContext(DbContextOptions<miniShopDbContext> options):base(options)
        {
            // dependency
            // hangi veri tabanından bağlanacağını seçmesi için
             
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(fk => fk.CategoryId);

               
            base.OnModelCreating(modelBuilder);
        }

       
    }
}
