
namespace ProductCategory
{
    partial class UrunEkle
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
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxProductPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxChooseProduct = new System.Windows.Forms.ComboBox();
            this.buttonRemoveProduct = new System.Windows.Forms.Button();
            this.comboBoxChooseCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxProductDescription = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.buttonUpdateProduct = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxProductRating = new System.Windows.Forms.TextBox();
            this.textBoxProductDiscount = new System.Windows.Forms.TextBox();
            this.textBoxProductInfos = new System.Windows.Forms.TextBox();
            this.textBoxImageAdress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(386, 47);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersWidth = 51;
            this.dataGridViewProducts.RowTemplate.Height = 24;
            this.dataGridViewProducts.Size = new System.Drawing.Size(598, 393);
            this.dataGridViewProducts.TabIndex = 8;
            this.dataGridViewProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxImageAdress);
            this.groupBox1.Controls.Add(this.textBoxProductInfos);
            this.groupBox1.Controls.Add(this.textBoxProductDiscount);
            this.groupBox1.Controls.Add(this.textBoxProductRating);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxProductPrice);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBoxChooseProduct);
            this.groupBox1.Controls.Add(this.buttonRemoveProduct);
            this.groupBox1.Controls.Add(this.comboBoxChooseCategory);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonAddProduct);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxProductDescription);
            this.groupBox1.Controls.Add(this.textBoxProductName);
            this.groupBox1.Controls.Add(this.buttonUpdateProduct);
            this.groupBox1.Location = new System.Drawing.Point(27, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 468);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // textBoxProductPrice
            // 
            this.textBoxProductPrice.Location = new System.Drawing.Point(121, 305);
            this.textBoxProductPrice.Name = "textBoxProductPrice";
            this.textBoxProductPrice.Size = new System.Drawing.Size(205, 22);
            this.textBoxProductPrice.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "İşlem yapmak istediğiniz ürünü seçiniz:";
            // 
            // comboBoxChooseProduct
            // 
            this.comboBoxChooseProduct.FormattingEnabled = true;
            this.comboBoxChooseProduct.Location = new System.Drawing.Point(31, 112);
            this.comboBoxChooseProduct.Name = "comboBoxChooseProduct";
            this.comboBoxChooseProduct.Size = new System.Drawing.Size(269, 24);
            this.comboBoxChooseProduct.TabIndex = 9;
            this.comboBoxChooseProduct.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseProduct_SelectedIndexChanged);
            // 
            // buttonRemoveProduct
            // 
            this.buttonRemoveProduct.Location = new System.Drawing.Point(9, 424);
            this.buttonRemoveProduct.Name = "buttonRemoveProduct";
            this.buttonRemoveProduct.Size = new System.Drawing.Size(91, 23);
            this.buttonRemoveProduct.TabIndex = 5;
            this.buttonRemoveProduct.Text = "Sil";
            this.buttonRemoveProduct.UseVisualStyleBackColor = true;
            this.buttonRemoveProduct.Click += new System.EventHandler(this.buttonRemoveProduct_Click);
            // 
            // comboBoxChooseCategory
            // 
            this.comboBoxChooseCategory.DisplayMember = "Name";
            this.comboBoxChooseCategory.FormattingEnabled = true;
            this.comboBoxChooseCategory.Location = new System.Drawing.Point(31, 53);
            this.comboBoxChooseCategory.Name = "comboBoxChooseCategory";
            this.comboBoxChooseCategory.Size = new System.Drawing.Size(269, 24);
            this.comboBoxChooseCategory.TabIndex = 8;
            this.comboBoxChooseCategory.ValueMember = "Id";
            this.comboBoxChooseCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseCategory_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Eklemek istediğiniz ürünü giriniz:";
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(121, 424);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(100, 23);
            this.buttonAddProduct.TabIndex = 4;
            this.buttonAddProduct.Text = "Ekle";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(275, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "İşlem yapmak istediğiniz kategoriyi seçiniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Açıklaması";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Adı";
            // 
            // textBoxProductDescription
            // 
            this.textBoxProductDescription.Location = new System.Drawing.Point(121, 250);
            this.textBoxProductDescription.Name = "textBoxProductDescription";
            this.textBoxProductDescription.Size = new System.Drawing.Size(205, 22);
            this.textBoxProductDescription.TabIndex = 1;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(121, 222);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(205, 22);
            this.textBoxProductName.TabIndex = 0;
            // 
            // buttonUpdateProduct
            // 
            this.buttonUpdateProduct.Location = new System.Drawing.Point(240, 424);
            this.buttonUpdateProduct.Name = "buttonUpdateProduct";
            this.buttonUpdateProduct.Size = new System.Drawing.Size(96, 23);
            this.buttonUpdateProduct.TabIndex = 6;
            this.buttonUpdateProduct.Text = "Güncelle";
            this.buttonUpdateProduct.UseVisualStyleBackColor = true;
            this.buttonUpdateProduct.Click += new System.EventHandler(this.buttonUpdateProduct_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "İndirim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Fiyat";
            // 
            // textBoxProductRating
            // 
            this.textBoxProductRating.Location = new System.Drawing.Point(121, 278);
            this.textBoxProductRating.Name = "textBoxProductRating";
            this.textBoxProductRating.Size = new System.Drawing.Size(205, 22);
            this.textBoxProductRating.TabIndex = 15;
            // 
            // textBoxProductDiscount
            // 
            this.textBoxProductDiscount.Location = new System.Drawing.Point(121, 333);
            this.textBoxProductDiscount.Name = "textBoxProductDiscount";
            this.textBoxProductDiscount.Size = new System.Drawing.Size(205, 22);
            this.textBoxProductDiscount.TabIndex = 16;
            // 
            // textBoxProductInfos
            // 
            this.textBoxProductInfos.Location = new System.Drawing.Point(121, 361);
            this.textBoxProductInfos.Name = "textBoxProductInfos";
            this.textBoxProductInfos.Size = new System.Drawing.Size(205, 22);
            this.textBoxProductInfos.TabIndex = 17;
            // 
            // textBoxImageAdress
            // 
            this.textBoxImageAdress.Location = new System.Drawing.Point(121, 194);
            this.textBoxImageAdress.Name = "textBoxImageAdress";
            this.textBoxImageAdress.Size = new System.Drawing.Size(205, 22);
            this.textBoxImageAdress.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Ürün Türü";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Puan";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Ürün Bİlgileri";
            // 
            // UrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 523);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.groupBox1);
            this.Name = "UrunEkle";
            this.Text = "UrunEkle";
            this.Load += new System.EventHandler(this.UrunEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRemoveProduct;
        private System.Windows.Forms.ComboBox comboBoxChooseCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProductDescription;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Button buttonUpdateProduct;
        private System.Windows.Forms.ComboBox comboBoxChooseProduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxProductPrice;
        private System.Windows.Forms.TextBox textBoxProductInfos;
        private System.Windows.Forms.TextBox textBoxProductDiscount;
        private System.Windows.Forms.TextBox textBoxProductRating;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxImageAdress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
    }
}