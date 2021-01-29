namespace ProductFormApp.Forms
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_newProductName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_products = new System.Windows.Forms.ComboBox();
            this.btn_delete_product = new System.Windows.Forms.Button();
            this.txt_desc_updated = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_categoryOfProduct = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_price_updated = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_update_product = new System.Windows.Forms.Button();
            this.datagridview_product = new System.Windows.Forms.DataGridView();
            this.btn_back_indexForm = new System.Windows.Forms.Button();
            this.txt_search_name = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add_product = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_product)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_newProductName
            // 
            this.txt_newProductName.Location = new System.Drawing.Point(311, 31);
            this.txt_newProductName.Name = "txt_newProductName";
            this.txt_newProductName.Size = new System.Drawing.Size(117, 20);
            this.txt_newProductName.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Yeni Adı : ";
            // 
            // cb_products
            // 
            this.cb_products.FormattingEnabled = true;
            this.cb_products.Location = new System.Drawing.Point(117, 31);
            this.cb_products.Name = "cb_products";
            this.cb_products.Size = new System.Drawing.Size(103, 21);
            this.cb_products.TabIndex = 28;
            // 
            // btn_delete_product
            // 
            this.btn_delete_product.Location = new System.Drawing.Point(279, 188);
            this.btn_delete_product.Name = "btn_delete_product";
            this.btn_delete_product.Size = new System.Drawing.Size(103, 27);
            this.btn_delete_product.TabIndex = 23;
            this.btn_delete_product.Text = "Ürün Sil";
            this.btn_delete_product.UseVisualStyleBackColor = true;
            this.btn_delete_product.Click += new System.EventHandler(this.btn_delete_product_Click);
            // 
            // txt_desc_updated
            // 
            this.txt_desc_updated.Location = new System.Drawing.Point(117, 104);
            this.txt_desc_updated.Name = "txt_desc_updated";
            this.txt_desc_updated.Size = new System.Drawing.Size(329, 20);
            this.txt_desc_updated.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Açıklama : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Adı : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_categoryOfProduct);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_price_updated);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_newProductName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cb_products);
            this.groupBox2.Controls.Add(this.btn_delete_product);
            this.groupBox2.Controls.Add(this.txt_desc_updated);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btn_update_product);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(552, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(495, 232);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ÜRÜN DÜZENLE";
            // 
            // cb_categoryOfProduct
            // 
            this.cb_categoryOfProduct.FormattingEnabled = true;
            this.cb_categoryOfProduct.Location = new System.Drawing.Point(117, 141);
            this.cb_categoryOfProduct.Name = "cb_categoryOfProduct";
            this.cb_categoryOfProduct.Size = new System.Drawing.Size(178, 21);
            this.cb_categoryOfProduct.TabIndex = 35;
            this.cb_categoryOfProduct.SelectionChangeCommitted += new System.EventHandler(this.cb_categoryOfProduct_SelectionChangeCommitted);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Kategori :";
            // 
            // txt_price_updated
            // 
            this.txt_price_updated.Location = new System.Drawing.Point(117, 70);
            this.txt_price_updated.Name = "txt_price_updated";
            this.txt_price_updated.Size = new System.Drawing.Size(329, 20);
            this.txt_price_updated.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Fiyat :";
            // 
            // btn_update_product
            // 
            this.btn_update_product.Location = new System.Drawing.Point(133, 188);
            this.btn_update_product.Name = "btn_update_product";
            this.btn_update_product.Size = new System.Drawing.Size(103, 27);
            this.btn_update_product.TabIndex = 4;
            this.btn_update_product.Text = "Ürün Güncelle";
            this.btn_update_product.UseVisualStyleBackColor = true;
            this.btn_update_product.Click += new System.EventHandler(this.btn_update_product_Click);
            // 
            // datagridview_product
            // 
            this.datagridview_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_product.Location = new System.Drawing.Point(15, 337);
            this.datagridview_product.Name = "datagridview_product";
            this.datagridview_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview_product.Size = new System.Drawing.Size(1035, 242);
            this.datagridview_product.TabIndex = 31;
            // 
            // btn_back_indexForm
            // 
            this.btn_back_indexForm.Location = new System.Drawing.Point(12, 12);
            this.btn_back_indexForm.Name = "btn_back_indexForm";
            this.btn_back_indexForm.Size = new System.Drawing.Size(51, 27);
            this.btn_back_indexForm.TabIndex = 28;
            this.btn_back_indexForm.Text = "Geri ";
            this.btn_back_indexForm.UseVisualStyleBackColor = true;
            this.btn_back_indexForm.Click += new System.EventHandler(this.btn_back_indexForm_Click);
            // 
            // txt_search_name
            // 
            this.txt_search_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_search_name.Location = new System.Drawing.Point(212, 303);
            this.txt_search_name.Name = "txt_search_name";
            this.txt_search_name.Size = new System.Drawing.Size(217, 20);
            this.txt_search_name.TabIndex = 32;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(128, 101);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(392, 20);
            this.txt_description.TabIndex = 22;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(128, 31);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(392, 20);
            this.txt_name.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Açıklama : ";
            // 
            // btn_add_product
            // 
            this.btn_add_product.Location = new System.Drawing.Point(417, 188);
            this.btn_add_product.Name = "btn_add_product";
            this.btn_add_product.Size = new System.Drawing.Size(103, 27);
            this.btn_add_product.TabIndex = 4;
            this.btn_add_product.Text = "Ürün Ekle";
            this.btn_add_product.UseVisualStyleBackColor = true;
            this.btn_add_product.Click += new System.EventHandler(this.btn_add_product_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Adı : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_stock);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cb_category);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_price);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_description);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_add_product);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 232);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÜRÜN EKLE";
            // 
            // cb_category
            // 
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(128, 188);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(178, 21);
            this.cb_category.TabIndex = 33;
            this.cb_category.SelectionChangeCommitted += new System.EventHandler(this.cb_category_SelectionChangeCommitted);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Kategori :";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(128, 66);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(392, 20);
            this.txt_price.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Fiyat : ";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(435, 299);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(42, 27);
            this.btn_search.TabIndex = 33;
            this.btn_search.Text = "Ara";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Arama yapılacak kategorinin adını giriniz : ";
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(128, 132);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(392, 20);
            this.txt_stock.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Stok : ";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 589);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.datagridview_product);
            this.Controls.Add(this.btn_back_indexForm);
            this.Controls.Add(this.txt_search_name);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label2);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_product)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txt_newProductName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_products;
        private System.Windows.Forms.Button btn_delete_product;
        public System.Windows.Forms.TextBox txt_desc_updated;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_update_product;
        public System.Windows.Forms.DataGridView datagridview_product;
        private System.Windows.Forms.Button btn_back_indexForm;
        private System.Windows.Forms.TextBox txt_search_name;
        public System.Windows.Forms.TextBox txt_description;
        public System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add_product;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_price_updated;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_categoryOfProduct;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.Label label11;
    }
}