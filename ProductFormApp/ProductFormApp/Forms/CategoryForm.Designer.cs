namespace ProductFormApp.Forms
{
    partial class CategoryForm
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
            this.datagridview_category = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add_category = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_back_indexForm = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_search_name = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_newCategoryName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_categories = new System.Windows.Forms.ComboBox();
            this.btn_delete_category = new System.Windows.Forms.Button();
            this.txt_desc_updated = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_update_category = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_category)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagridview_category
            // 
            this.datagridview_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_category.Location = new System.Drawing.Point(12, 309);
            this.datagridview_category.Name = "datagridview_category";
            this.datagridview_category.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview_category.Size = new System.Drawing.Size(1035, 242);
            this.datagridview_category.TabIndex = 24;
            this.datagridview_category.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_category_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_description);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_add_category);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 165);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KATEGORİ EKLE";
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(128, 69);
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
            this.label1.Location = new System.Drawing.Point(17, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Açıklama : ";
            // 
            // btn_add_category
            // 
            this.btn_add_category.Location = new System.Drawing.Point(128, 111);
            this.btn_add_category.Name = "btn_add_category";
            this.btn_add_category.Size = new System.Drawing.Size(103, 27);
            this.btn_add_category.TabIndex = 4;
            this.btn_add_category.Text = "Kategori Ekle";
            this.btn_add_category.UseVisualStyleBackColor = true;
            this.btn_add_category.Click += new System.EventHandler(this.btn_add_category_Click);
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
            // btn_back_indexForm
            // 
            this.btn_back_indexForm.Location = new System.Drawing.Point(12, 12);
            this.btn_back_indexForm.Name = "btn_back_indexForm";
            this.btn_back_indexForm.Size = new System.Drawing.Size(51, 27);
            this.btn_back_indexForm.TabIndex = 22;
            this.btn_back_indexForm.Text = "Geri ";
            this.btn_back_indexForm.UseVisualStyleBackColor = true;
            this.btn_back_indexForm.Click += new System.EventHandler(this.btn_back_indexForm_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(432, 271);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(42, 27);
            this.btn_search.TabIndex = 26;
            this.btn_search.Text = "Ara";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Arama yapılacak kategorinin adını giriniz : ";
            // 
            // txt_search_name
            // 
            this.txt_search_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_search_name.Location = new System.Drawing.Point(209, 275);
            this.txt_search_name.Name = "txt_search_name";
            this.txt_search_name.Size = new System.Drawing.Size(217, 20);
            this.txt_search_name.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_newCategoryName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cb_categories);
            this.groupBox2.Controls.Add(this.btn_delete_category);
            this.groupBox2.Controls.Add(this.txt_desc_updated);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btn_update_category);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(552, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 165);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "KATEGORİ DÜZENLE";
            // 
            // txt_newCategoryName
            // 
            this.txt_newCategoryName.Location = new System.Drawing.Point(311, 31);
            this.txt_newCategoryName.Name = "txt_newCategoryName";
            this.txt_newCategoryName.Size = new System.Drawing.Size(117, 20);
            this.txt_newCategoryName.TabIndex = 30;
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
            // cb_categories
            // 
            this.cb_categories.FormattingEnabled = true;
            this.cb_categories.Location = new System.Drawing.Point(128, 28);
            this.cb_categories.Name = "cb_categories";
            this.cb_categories.Size = new System.Drawing.Size(103, 21);
            this.cb_categories.TabIndex = 28;
            this.cb_categories.SelectionChangeCommitted += new System.EventHandler(this.cb_categories_SelectionChangeCommitted);
            // 
            // btn_delete_category
            // 
            this.btn_delete_category.Location = new System.Drawing.Point(274, 111);
            this.btn_delete_category.Name = "btn_delete_category";
            this.btn_delete_category.Size = new System.Drawing.Size(103, 27);
            this.btn_delete_category.TabIndex = 23;
            this.btn_delete_category.Text = "Kategori Sil";
            this.btn_delete_category.UseVisualStyleBackColor = true;
            this.btn_delete_category.Click += new System.EventHandler(this.btn_delete_category_Click);
            // 
            // txt_desc_updated
            // 
            this.txt_desc_updated.Location = new System.Drawing.Point(128, 69);
            this.txt_desc_updated.Name = "txt_desc_updated";
            this.txt_desc_updated.Size = new System.Drawing.Size(329, 20);
            this.txt_desc_updated.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Açıklama : ";
            // 
            // btn_update_category
            // 
            this.btn_update_category.Location = new System.Drawing.Point(128, 111);
            this.btn_update_category.Name = "btn_update_category";
            this.btn_update_category.Size = new System.Drawing.Size(103, 27);
            this.btn_update_category.TabIndex = 4;
            this.btn_update_category.Text = "Kategori Güncelle";
            this.btn_update_category.UseVisualStyleBackColor = true;
            this.btn_update_category.Click += new System.EventHandler(this.btn_update_category_Click);
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
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 617);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.datagridview_category);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_back_indexForm);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_search_name);
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_category)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView datagridview_category;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add_category;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_back_indexForm;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_search_name;
        public System.Windows.Forms.TextBox txt_description;
        public System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_delete_category;
        public System.Windows.Forms.TextBox txt_desc_updated;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_update_category;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_categories;
        public System.Windows.Forms.TextBox txt_newCategoryName;
        private System.Windows.Forms.Label label5;
    }
}