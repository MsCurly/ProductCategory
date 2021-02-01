using ProductCategory.Data;
using ProductCategory.Models;
using ProductCategory.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductCategory
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        //Veritabanına bağlanıyoruz
        miniShopDbContext dbContext = new miniShopDbContext();
        CategoryBusiness categoryBusiness = new CategoryBusiness();

        //Ekelenen kategorileri formda görmek için:
        public void getCategories()
        {
            dataGridViewCategories.DataSource = categoryBusiness.GetCategories();
        }
       
        
        private void Form1_Load(object sender, EventArgs e)
        {                      
            getCategoriesToSelect();
            getCategories();
            getProducts();            
        }

        private void getCategoriesToSelect()
        {
            comboBoxUpdateCategory.DataSource = dbContext.Categories.ToList();
            comboBoxUpdateCategory.DisplayMember = "Name";
            comboBoxUpdateCategory.ValueMember = "Id";
        }
        

        //Ekelenen kategorileri formda görmek için:
        private void getProducts()
        {
            comboBoxProducts.DataSource = dbContext.Products.Select(p => new { p.Id, p.Name }).ToList();
            //Ekranda göstereceyi şey isim:
            comboBoxProducts.DisplayMember = "Name";
            //Saklayacağı şey Id'si:
            comboBoxProducts.ValueMember = "Id";

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

      
        private void buttonAddCategory_Click(object sender, EventArgs e)
        {            
            Category newCategory = new Category();
            newCategory.Name = textBoxCategoryName.Text;
            newCategory.Description = textBoxCategoryDescription.Text;

            categoryBusiness.Add(newCategory);
            getCategories();            
        }

        Category selectedCategory = null;
        private void buttonUpdateCategory_Click(object sender, EventArgs e)
        {
            selectedCategory.Name = textBoxCategoryName.Text;
            selectedCategory.Description = textBoxCategoryDescription.Text;
            categoryBusiness.Edit(selectedCategory);
            getCategories();
            
        }


        private void comboBoxUpdateCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedCategoryId = (int)comboBoxUpdateCategory.SelectedValue;
            ////bana bir category parametresi ver, bunun kriterlerini söyle (true veya false döndürekecek) ben de ona göre filtreleyeyim.
            //var category = dbContext.Categories.Where(c => c.Id == selectedCategoryId).FirstOrDefault();

            var category = categoryBusiness.GetCategoryById(selectedCategoryId);

            selectedCategory = category;
            
            textBoxCategoryName.Text = category.Name;
            textBoxCategoryDescription.Text = category.Description;

            buttonUpdateCategory.Enabled = true;
            buttonRemoveCategory.Enabled = true;

        }

        private void buttonRemoveCategory_Click(object sender, EventArgs e)
        {            
            categoryBusiness.Remove(selectedCategory);
            getCategories();          
        }

        public void comboBoxProducts_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var selectedProductId = (int)comboBoxProducts.SelectedValue;
            var product = dbContext.Products.Find(selectedProductId);
            MessageBox.Show($"{product.Name} isimli ürünün fiyatı {product.Price} ve puanı {product.Rating}");
        }

        //Ürün eklemek için yeni formun açılması 
       
        private void buttonAddNewProduct_Click(object sender, EventArgs e)
        {
            UrunEkle urunEkleme = new UrunEkle();
            urunEkleme.Show();
        }
    }
}
