using miniShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniShop.Services
{
    public class FakeProductService : IProductService
    {
        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product{Id=1, Name="Eşorfman", Description="kadın gri eşorfman", ImageUrl=" https://cdn.dsmcdn.com/mnresize/415/622/ty26/product/media/images/20201121/17/30054662/59471291/1/1_org.jpg", Price= 80, Discount= 0.25, Rating=4.3} ,
                new Product{Id=2, Name="EşorfmanX", Description="kadın gri eşorfman", ImageUrl=" https://cdn.dsmcdn.com/mnresize/415/622/ty26/product/media/images/20201121/17/30054662/59471291/1/1_org.jpg", Price= 80, Discount= 0.25, Rating=4.3} ,
                new Product{Id=3, Name="EşorfmanY", Description="kadın gri eşorfman", ImageUrl=" https://cdn.dsmcdn.com/mnresize/415/622/ty26/product/media/images/20201121/17/30054662/59471291/1/1_org.jpg", Price= 80, Discount= 0.25, Rating=4.3} ,
                new Product{Id=4, Name="EşorfmanZ", Description="kadın gri eşorfman", ImageUrl=" https://cdn.dsmcdn.com/mnresize/415/622/ty26/product/media/images/20201121/17/30054662/59471291/1/1_org.jpg", Price= 80, Discount= 0.25, Rating=4.3} ,
                new Product{Id=5, Name="EşorfmanA", Description="kadın gri eşorfman", ImageUrl=" https://cdn.dsmcdn.com/mnresize/415/622/ty26/product/media/images/20201121/17/30054662/59471291/1/1_org.jpg", Price= 80, Discount= 0.25, Rating=4.3} ,
                new Product{Id=6, Name="EşorfmanK", Description="kadın gri eşorfman", ImageUrl=" https://cdn.dsmcdn.com/mnresize/415/622/ty26/product/media/images/20201121/17/30054662/59471291/1/1_org.jpg", Price= 80, Discount= 0.25, Rating=4.3} ,
                new Product{Id=7, Name="EşorfmanK", Description="kadın gri eşorfman", ImageUrl=" https://cdn.dsmcdn.com/mnresize/415/622/ty26/product/media/images/20201121/17/30054662/59471291/1/1_org.jpg", Price= 80, Discount= 0.25, Rating=4.3} ,
                new Product{Id=8, Name="EşorfmanK", Description="kadın gri eşorfman", ImageUrl=" https://cdn.dsmcdn.com/mnresize/415/622/ty26/product/media/images/20201121/17/30054662/59471291/1/1_org.jpg", Price= 80, Discount= 0.25, Rating=4.3} ,
                new Product{Id=9, Name="EşorfmanK", Description="kadın gri eşorfman", ImageUrl=" https://cdn.dsmcdn.com/mnresize/415/622/ty26/product/media/images/20201121/17/30054662/59471291/1/1_org.jpg", Price= 80, Discount= 0.25, Rating=4.3} ,
                new Product{Id=10, Name="EşorfmanK", Description="kadın gri eşorfman", ImageUrl=" https://cdn.dsmcdn.com/mnresize/415/622/ty26/product/media/images/20201121/17/30054662/59471291/1/1_org.jpg", Price= 80, Discount= 0.25, Rating=4.3} ,
                new Product{Id=11, Name="EşorfmanK", Description="kadın gri eşorfman", ImageUrl=" https://cdn.dsmcdn.com/mnresize/415/622/ty26/product/media/images/20201121/17/30054662/59471291/1/1_org.jpg", Price= 80, Discount= 0.25, Rating=4.3} ,
                new Product{Id=12, Name="EşorfmanK", Description="kadın gri eşorfman", ImageUrl=" https://cdn.dsmcdn.com/mnresize/415/622/ty26/product/media/images/20201121/17/30054662/59471291/1/1_org.jpg", Price= 80, Discount= 0.25, Rating=4.3} ,

            };
        }
    }

}

