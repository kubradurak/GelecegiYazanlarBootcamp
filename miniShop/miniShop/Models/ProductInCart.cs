using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniShop.Models
{
    public class ProductInCart
    {
        // her bir ürün için bir cart sepetteki bir ürün yani
        public Product Product { get; set; }
        public int Quantity { get; set; }

    }
}
