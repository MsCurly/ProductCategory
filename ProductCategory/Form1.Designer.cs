﻿
namespace ProductCategory
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxUpdateCategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonUpdateCategory = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCategoryDescription = new System.Windows.Forms.TextBox();
            this.textBoxCategoryName = new System.Windows.Forms.TextBox();
            this.buttonRemoveCategory = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewCategories = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.buttonAddNewProduct = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRemoveCategory);
            this.groupBox1.Controls.Add(this.comboBoxUpdateCategory);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonAddCategory);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxCategoryDescription);
            this.groupBox1.Controls.Add(this.textBoxCategoryName);
            this.groupBox1.Controls.Add(this.buttonUpdateCategory);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // comboBoxUpdateCategory
            // 
            this.comboBoxUpdateCategory.FormattingEnabled = true;
            this.comboBoxUpdateCategory.Location = new System.Drawing.Point(47, 93);
            this.comboBoxUpdateCategory.Name = "comboBoxUpdateCategory";
            this.comboBoxUpdateCategory.Size = new System.Drawing.Size(269, 24);
            this.comboBoxUpdateCategory.TabIndex = 8;
            this.comboBoxUpdateCategory.SelectionChangeCommitted += new System.EventHandler(this.comboBoxUpdateCategory_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(349, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Güncellemek veya silmek istediğiniz kategoriyi seçiniz:";
            // 
            // buttonUpdateCategory
            // 
            this.buttonUpdateCategory.Location = new System.Drawing.Point(237, 257);
            this.buttonUpdateCategory.Name = "buttonUpdateCategory";
            this.buttonUpdateCategory.Size = new System.Drawing.Size(96, 23);
            this.buttonUpdateCategory.TabIndex = 6;
            this.buttonUpdateCategory.Text = "Güncelle";
            this.buttonUpdateCategory.UseVisualStyleBackColor = true;
            this.buttonUpdateCategory.Click += new System.EventHandler(this.buttonUpdateCategory_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Eklemek istediğiniz kategoriyi giriniz:";
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Location = new System.Drawing.Point(118, 257);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(100, 23);
            this.buttonAddCategory.TabIndex = 4;
            this.buttonAddCategory.Text = "Ekle";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Açıklaması";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategori Adı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxCategoryDescription
            // 
            this.textBoxCategoryDescription.Location = new System.Drawing.Point(128, 213);
            this.textBoxCategoryDescription.Name = "textBoxCategoryDescription";
            this.textBoxCategoryDescription.Size = new System.Drawing.Size(205, 22);
            this.textBoxCategoryDescription.TabIndex = 1;
            // 
            // textBoxCategoryName
            // 
            this.textBoxCategoryName.Location = new System.Drawing.Point(128, 185);
            this.textBoxCategoryName.Name = "textBoxCategoryName";
            this.textBoxCategoryName.Size = new System.Drawing.Size(205, 22);
            this.textBoxCategoryName.TabIndex = 0;
            // 
            // buttonRemoveCategory
            // 
            this.buttonRemoveCategory.Location = new System.Drawing.Point(6, 257);
            this.buttonRemoveCategory.Name = "buttonRemoveCategory";
            this.buttonRemoveCategory.Size = new System.Drawing.Size(91, 23);
            this.buttonRemoveCategory.TabIndex = 5;
            this.buttonRemoveCategory.Text = "Sil";
            this.buttonRemoveCategory.UseVisualStyleBackColor = true;
            this.buttonRemoveCategory.Click += new System.EventHandler(this.buttonRemoveCategory_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(490, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kategoriler";
            // 
            // dataGridViewCategories
            // 
            this.dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategories.Location = new System.Drawing.Point(429, 64);
            this.dataGridViewCategories.Name = "dataGridViewCategories";
            this.dataGridViewCategories.RowHeadersWidth = 51;
            this.dataGridViewCategories.RowTemplate.Height = 24;
            this.dataGridViewCategories.Size = new System.Drawing.Size(493, 305);
            this.dataGridViewCategories.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Yeni ürün eklemek için ";
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(429, 375);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(322, 24);
            this.comboBoxProducts.TabIndex = 3;
            this.comboBoxProducts.SelectionChangeCommitted += new System.EventHandler(this.comboBoxProducts_SelectionChangeCommitted);
            // 
            // buttonAddNewProduct
            // 
            this.buttonAddNewProduct.Location = new System.Drawing.Point(282, 482);
            this.buttonAddNewProduct.Name = "buttonAddNewProduct";
            this.buttonAddNewProduct.Size = new System.Drawing.Size(90, 33);
            this.buttonAddNewProduct.TabIndex = 5;
            this.buttonAddNewProduct.Text = "Tıkla";
            this.buttonAddNewProduct.UseVisualStyleBackColor = true;
            this.buttonAddNewProduct.Click += new System.EventHandler(this.buttonAddNewProduct_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 557);
            this.Controls.Add(this.buttonAddNewProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewCategories);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCategoryDescription;
        private System.Windows.Forms.TextBox textBoxCategoryName;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewCategories;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonUpdateCategory;
        private System.Windows.Forms.Button buttonRemoveCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.ComboBox comboBoxUpdateCategory;
        private System.Windows.Forms.Button buttonAddNewProduct;
    }
}

