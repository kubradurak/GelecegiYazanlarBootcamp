using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFormApp.Models
{
    public class Category
    {
        public int Id { get; set; } // PK
        public string Name { get; set; }
        public string Description { get; set; }
       

        public IList<Product> Products { get; set; }

    }
}
