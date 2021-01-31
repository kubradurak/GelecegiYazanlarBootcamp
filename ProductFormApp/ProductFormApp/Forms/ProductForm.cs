using ProductFormApp.Data;
using ProductFormApp.Models;
using ProductFormApp.Services;
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
    public partial class ProductForm : Form
    {
        FormDbContext db = new FormDbContext();
        ProductServices productServices = new ProductServices();
        

        public ProductForm()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var result = productServices.GetProductByName(txt_search_name.Text);
            datagridview_product.DataSource = db.Products.Where(c => c.Id == result.Id).ToList();
        }

        private void btn_add_product_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product();
            if (string.IsNullOrEmpty(txt_name.Text))
            {
                MessageBox.Show("Kategori adı boş olamaz!");
            }
            else
            {
                newProduct.Name = txt_name.Text;
                newProduct.Price = Convert.ToDecimal( txt_price.Text);
                newProduct.CategoryId = (int) cb_category.SelectedValue;
                newProduct.Stock = Convert.ToInt32(txt_stock.Text);
                newProduct.Description = txt_description.Text;

                
                bool IsSaved = productServices.CheckProduct(newProduct);


                if (IsSaved == true)
                {
                    int affectedRow = productServices.AddProduct(newProduct);

                    if (affectedRow > 0)
                    {
                        MessageBox.Show("Ekleme başarılı");
                        getProductData();

                        getProducts();
                    }
                    else
                    {
                        MessageBox.Show("Ekleme başarısız!");
                    }
                }
                else
                {
                    MessageBox.Show("Aynı isimde ürün var! Stock güncellemesi yapılacak");
                    productServices.AddStockByName(newProduct);
                    getProductData();
                    getCategories();
                    getProducts();
                    clearTxt();
                }
            }
        }

        private void clearTxt()
        {
            txt_description.Text = "";
            txt_name.Text = "";
            txt_price.Text = "";

        }

        private void getCategories()
        {
            cb_category.DataSource = db.Categories.Select(c => new { c.Id, c.Name }).ToList();
            cb_category.DisplayMember = "Name";
            cb_category.ValueMember = "Id";

            cb_categoryOfProduct.DataSource = db.Categories.Select(c => new { c.Id, c.Name }).ToList();
            cb_categoryOfProduct.DisplayMember = "Name";
            cb_categoryOfProduct.ValueMember = "Id";
        }

        private void getProductData()
        {
            datagridview_product.DataSource = db.Products.ToList();

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            getProductData();
            getCategories();
            getProducts();

        }

        private void getProducts()
        {
            cb_products.DataSource = db.Products.Select(c => new { c.Id, c.Name }).ToList();
            cb_products.DisplayMember = "Name";
            cb_products.ValueMember = "Id";
        }

        private void cb_category_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var selectedCategory = productServices.GetCategoryById((int)cb_category.SelectedValue);
                
        }

        private void btn_back_indexForm_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void btn_delete_product_Click(object sender, EventArgs e)
        {
            var selectedProductId = (int)cb_products.SelectedValue;

            productServices.DeleteProduct(selectedProductId);
            txt_desc_updated.Text = "";
            getProductData();
            getCategories();
            getProducts();
        }

        private void btn_update_product_Click(object sender, EventArgs e)
        {
            var selectedCategoryId = (int)cb_category.SelectedValue;
            var selectedProductId = (int)cb_products.SelectedValue;
            Product selectedProduct = new Product
            {
                Id = selectedProductId,
                Name = txt_newProductName.Text,
                Price = Convert.ToDecimal(txt_price_updated.Text),
                Description = txt_desc_updated.Text,
                CategoryId = selectedCategoryId

            };
           
            int affectedRow = productServices.UpdateProduct(selectedProduct); 

            if (affectedRow > 0)
            {
                MessageBox.Show("Güncelleme başarılı");
                getProductData();
                getCategories();
                getProducts();
            }
            else
            {
                MessageBox.Show("Ekleme başarısız!");
            }


            
        }

        private void cb_categoryOfProduct_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }
    }
}
