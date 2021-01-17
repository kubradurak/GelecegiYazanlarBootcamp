using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentModals.Modals
{
    public class Category
    {
        public int Id { get; set; } // PK
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProductId { get; set; } //FK ???
        public Product Product { get; set; }

        public IList<Product> Products { get; set; } // Bir kategorinin birden fazla ürünü olabilir.

    }
}
