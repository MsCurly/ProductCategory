using ProductCategory.Models;
using ProductCategory.Data;
using ProductCategory.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductCategory
{
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }
        
        miniShopDbContext dbContext = new miniShopDbContext();
        ProductBusiness productBusiness = new ProductBusiness();

        public void getProducts()
        {
            dataGridViewProducts.DataSource = dbContext.Products.ToList();           
        }

        public void getProduct()
        {
            dataGridViewProducts.DataSource = dbContext.Products.ToList();
        }

        private void getProductsToSelect()
        {
            var productList = from product in dbContext.Products where product.CategoryId == 1 select product;
            comboBoxChooseProduct.DisplayMember = "Name";
            comboBoxChooseProduct.ValueMember = "Id";
            comboBoxChooseProduct.DataSource = productList.ToList();
        }

        private void getCategories()
        {
            comboBoxChooseCategory.DataSource = dbContext.Categories.Select(c => new { c.Id, c.Name }).ToList();
           // comboBoxChooseCategory.DisplayMember = "Name";
        }




        private void UrunEkle_Load(object sender, EventArgs e)
        {
            getCategories();
            getProductsToSelect();
            getProducts();
        }
        
        private void comboBoxChooseCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedId = (int)comboBoxChooseCategory.SelectedValue;
            var productList = from product in dbContext.Products where product.CategoryId == selectedId select product;
            comboBoxChooseProduct.DisplayMember = "Name";
            comboBoxChooseProduct.ValueMember = "Id";
            comboBoxChooseProduct.DataSource = productList.ToList();


        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product();
            newProduct.ImageAdress = textBoxImageAdress.Text;
            newProduct.Name = textBoxProductName.Text;
            newProduct.Description = textBoxProductDescription.Text;
            newProduct.Rating = Convert.ToDouble(textBoxProductRating.Text);
            newProduct.Price = Convert.ToDecimal(textBoxProductPrice.Text);
            newProduct.Discount = Convert.ToDouble(textBoxProductDiscount.Text);
            newProduct.ProductInfos = textBoxProductInfos.Text;

            productBusiness.Add(newProduct);
            int affectedRow = dbContext.SaveChanges();
            if (affectedRow > 0)
            {
                MessageBox.Show("başarılı");
                getProducts();
            }
            else
            {
                MessageBox.Show("olmadı");
            }
           
        }

        Product selectedProduct = null;

        private void buttonUpdateProduct_Click(object sender, EventArgs e)
        {
            selectedProduct.ImageAdress = textBoxImageAdress.Text;
            selectedProduct.Name = textBoxProductName.Text;
            selectedProduct.Description = textBoxProductDescription.Text;
            selectedProduct.Rating = Convert.ToDouble(textBoxProductRating.Text);
            selectedProduct.Price = Convert.ToDecimal(textBoxProductPrice.Text);
            selectedProduct.Discount = Convert.ToDouble(textBoxProductDiscount.Text);
            selectedProduct.ProductInfos = textBoxProductInfos.Text;
            
            productBusiness.Edit(selectedProduct);
            getProducts();
           
        }

        private void buttonRemoveProduct_Click(object sender, EventArgs e)
        {
            productBusiness.Remove(selectedProduct);
            getProducts();
        }

        private void comboBoxChooseProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedProductId = (int)comboBoxChooseProduct.SelectedValue;
            var product = productBusiness.GetProductById(selectedProductId);

            selectedProduct = product;

            textBoxImageAdress.Text = product.ImageAdress;
            textBoxProductName.Text = product.Name;
            textBoxProductDescription.Text = product.Description;
            textBoxProductRating.Text = Convert.ToString(product.Rating);
            textBoxProductPrice.Text = Convert.ToString(product.Price);
            textBoxProductDiscount.Text = Convert.ToString(product.Discount);
            textBoxProductInfos.Text = product.ProductInfos;


            buttonUpdateProduct.Enabled = true;
            buttonRemoveProduct.Enabled = true;
        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
