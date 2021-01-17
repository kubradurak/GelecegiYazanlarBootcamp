using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentModals.Modals
{
    public class Product
    {
        public int Id { get; set; } // PK
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        public int CategoryId { get; set; } //FK
        public Category Category { get; set; }
        

    }
}
