using AssignmentModals.Modals;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentModals.Data
{
    class TurkcellDbContext : DbContext
    {
        public TurkcellDbContext(DbContextOptions<TurkcellDbContext> options):base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // one -many ilişki 
            modelBuilder.Entity<Category>() // bir categorynin birden fazla ürünü vardır. 
                .HasMany(x => x.Products)
                .WithOne(y => y.Category)
                .HasForeignKey(z => z.CategoryId);

            // one - one ilişki 
            modelBuilder.Entity<Product>()
                .HasOne<Category>(s => s.Category)
                .WithOne(k => k.Product)
                .HasForeignKey<Category>(t => t.ProductId);

                ;

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) // eğer seferinde çalışmasını istemiyorum.
            {
                //useSqlServer
            }
        }
        }
}
