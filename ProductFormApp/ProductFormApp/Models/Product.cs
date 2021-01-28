using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFormApp.Models
{
    public class Product
    {
        public int Id { get; set; } // PK
        public string Name { get; set; }
        public double Rating { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public int CategoryId { get; set; } //FK
        public Category Category { get; set; }
    }
}
