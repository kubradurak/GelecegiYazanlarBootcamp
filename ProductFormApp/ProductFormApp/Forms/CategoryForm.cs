using Microsoft.EntityFrameworkCore;
using ProductFormApp.Controllers;
using ProductFormApp.Data;
using ProductFormApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductFormApp.Forms
{
    public partial class CategoryForm : Form
    {
        CategoryControl categoryControl = new CategoryControl();

        Category newCategory = new Category();
        FormDbContext db = new FormDbContext();


        public CategoryForm()
        {
            InitializeComponent();
        }

        private void btn_back_indexForm_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void btn_add_category_Click(object sender, EventArgs e)
        {
            Category newCategory = new Category();
            if (string.IsNullOrEmpty(txt_name.Text))
            {
                MessageBox.Show("Kategori adı boş olamaz!");
            }
            else
            {
                newCategory.Name = txt_name.Text;
                newCategory.Description = txt_description.Text;
                var IsSavedCategory = db.Categories.Where(c => c.Name.ToLower() == newCategory.Name.ToLower());

                bool IsSaved;
                if (IsSavedCategory != null)
                {
                    IsSaved = true;
                }
                else
                {
                    IsSaved = false;
                }
                if (IsSaved == true)
                {
                    int affectedRow = categoryControl.AddCategory(newCategory);

                    if (affectedRow > 0)
                    {
                        MessageBox.Show("Ekleme başarılı");
                        getCategoryData();
                        getCategoies();
                    }
                    else
                    {
                        MessageBox.Show("Ekleme başarısız!");
                    }
                }
                else
                {
                    MessageBox.Show("Aynı isimde kategori var! Ekleme yapılmadı");
                    clearTxt();
                }
            }
        }

        private void clearTxt()
        {
            txt_description.Text = "";
            txt_name.Text = "";
        }

        private void getCategoryData()
        {
            datagridview_category.DataSource = db.Categories.ToList();

        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            getCategoryData();
            getCategoies();

        }

        private void getCategoies()
        {
            cb_categories.DataSource = db.Categories.AsNoTracking().Select(c => new { c.Id, c.Name }).ToList();

            cb_categories.DisplayMember = "Name"; 
            cb_categories.ValueMember = "Id"; 
            
             

           
        }

        private void datagridview_category_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedCategory = db.Categories.Select(c => new { c.Id, c.Name, c.Description }).ToList();
           

        }

        private void btn_delete_category_Click(object sender, EventArgs e)
        {

            var selectedCategoryId = (int)cb_categories.SelectedValue;
            bool HasProduct = true;

            var productsOfCategory = db.Categories.Select(c => c.Products).ToList();


            if (productsOfCategory != null)
            {
                HasProduct = true;
            }
            else
            {
                HasProduct = false;
            }

            if (HasProduct == false)
            {
                categoryControl.DeleteCategory(selectedCategoryId);
                txt_desc_updated.Text = "";
                getCategoies();
                getCategoryData();
            }
            else
            {
                MessageBox.Show($"{cb_categories.SelectedValue} ait ürünler olduğu için silemezsiniz!");
            }


        }

        private void cb_categories_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var selectedCategory = categoryControl.GetCategoryById((int)cb_categories.SelectedValue);
            txt_desc_updated.Text = selectedCategory.Description;
        }

        private void btn_update_category_Click(object sender, EventArgs e)
        {
            var selectedCategoryId = (int)cb_categories.SelectedValue;

            Category selectedCategory = new Category{
                Id = selectedCategoryId,
                    Name = txt_newCategoryName.Text,
                   Description = txt_desc_updated.Text };
                categoryControl.UpdateCategory(selectedCategory);

            int affectedRow = categoryControl.UpdateCategory(selectedCategory); ;

            if (affectedRow > 0)
            {
                MessageBox.Show("Güncelleme başarılı");
                getCategoies();
                getCategoryData();
            }
            else
            {
                MessageBox.Show("Ekleme başarısız!");
            }

          

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            
            var result = categoryControl.GetCategoryByName(txt_search_name.Text);
            datagridview_category.DataSource = db.Categories.Where(c => c.Id == result.Id).ToList();

        }
    }
}
