using Microsoft.EntityFrameworkCore;
using ProductFormApp.Data;
using ProductFormApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductFormApp.Services
{
    public class CategoryServices : ICategoryServices
    {
        FormDbContext db = new FormDbContext();
        public int AddCategory(Category category)
        {
            db.Categories.Add(category);
            int affectedRow = db.SaveChanges();
            return affectedRow;
        }

        public bool CheckCategory(Category _category)
        {
            bool IsSavedCategory = false;
            foreach (var category in db.Categories)
            {
                if (category.Name.ToLower() == _category.Name.ToLower())
                {
                    IsSavedCategory = true;
                }
            }
            return IsSavedCategory;
        }

        public int DeleteCategory(int _id)
        {
            var deletedCategory = db.Categories.Find(_id);
            if (deletedCategory.Id == _id)
            {
                db.Categories.Remove(deletedCategory);
            }
            else
            {
                MessageBox.Show("Başarısız");
            }

            return db.SaveChanges();
        }

        public Category GetCategoryById(int selectedValue)
        {
            return db.Categories.AsNoTracking().FirstOrDefault(c => c.Id == selectedValue);
        }

        public Category GetCategoryByName(string selectedCategoryName)
        {
            return db.Categories.FirstOrDefault(c => c.Name == selectedCategoryName);
        }

        public int UpdateCategory(Category category)
        {
            db.Entry(category).State = EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
