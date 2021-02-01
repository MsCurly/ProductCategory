using ProductCategory.Data;
using ProductCategory.Models;
using ProductCategory.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Services
{
    public class ProductBusiness
    {
        miniShopDbContext dbContext = new miniShopDbContext();

        public List<Product> GetProducts()
        {
            return dbContext.Products.ToList();
        }

       
        public Product GetProductById(int id)
        {
            return dbContext.Products.Find(id);
        }
        public void Add(Product product)
        {
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
        }

        public void Remove(Product product)
        {
            dbContext.Products.Remove(product);
            dbContext.SaveChanges();
        }

        public void Edit(Product product)
        {
            dbContext.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();

        }
    }
}
