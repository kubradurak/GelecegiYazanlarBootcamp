using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniShop.Models
{
    public class Cart
    {
        private List<ProductInCart> products = new List<ProductInCart>();
        public void AddItem(Product product, int quatity)
        {
            var existingProduct = products.FirstOrDefault(x => x.Product.Id == product.Id);
            if (existingProduct == null )
            {
                products.Add(new ProductInCart { Product = product, Quantity = quatity });

            }
            else
            {
                existingProduct.Quantity += quatity;

            }

        }
        public void Remove(Product product) => products.RemoveAll(p => p.Product.Id == product.Id);
        public void Clear(Product product) => products.Clear();
        public decimal GetTotalValue()=> (decimal)products.Sum(x => x.Product.Price * x.Quantity);

        public IEnumerable<ProductInCart> Products => products;

    }
}
