namespace ProductFormApp
{
    partial class Form1
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
            this.btn_category = new System.Windows.Forms.Button();
            this.btn_product = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_category
            // 
            this.btn_category.Location = new System.Drawing.Point(65, 61);
            this.btn_category.Name = "btn_category";
            this.btn_category.Size = new System.Drawing.Size(194, 75);
            this.btn_category.TabIndex = 3;
            this.btn_category.Text = "Kategori İşlemleri";
            this.btn_category.UseVisualStyleBackColor = true;
            this.btn_category.Click += new System.EventHandler(this.btn_category_Click);
            // 
            // btn_product
            // 
            this.btn_product.Location = new System.Drawing.Point(65, 165);
            this.btn_product.Name = "btn_product";
            this.btn_product.Size = new System.Drawing.Size(194, 75);
            this.btn_product.TabIndex = 2;
            this.btn_product.Text = "Ürün İşlemleri";
            this.btn_product.UseVisualStyleBackColor = true;
            this.btn_product.Click += new System.EventHandler(this.btn_product_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 318);
            this.Controls.Add(this.btn_category);
            this.Controls.Add(this.btn_product);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_category;
        private System.Windows.Forms.Button btn_product;
    }
}

