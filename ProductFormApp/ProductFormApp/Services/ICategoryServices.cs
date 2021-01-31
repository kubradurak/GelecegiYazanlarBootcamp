using ProductFormApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFormApp.Services
{
    public interface ICategoryServices
    {
        int AddCategory(Category category);
        int DeleteCategory(int _id);
        int UpdateCategory(Category category);
        Category GetCategoryById(int selectedValue);
        Category GetCategoryByName(string selectedCategoryName);
        bool CheckCategory(Category _category);


        }
}
