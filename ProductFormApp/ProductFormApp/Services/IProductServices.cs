using ProductFormApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFormApp.Services
{
    public interface IProductServices
    {
        int AddProduct(Product product);
        int UpdateProduct(Product product);
        int DeleteProduct(int _id);
        Product GetProductById(int _selectedProductId);
        Product GetProductByName(string _selectedProductName);
        Category GetCategoryById(int selectedValue);
        void AddStockByName(Product _product);
        bool CheckProduct(Product _product);


    }
}
