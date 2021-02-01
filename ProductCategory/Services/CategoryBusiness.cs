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
    public class CategoryBusiness
    {
        miniShopDbContext dbContext = new miniShopDbContext();

        public List<Category> GetCategories()
        {
            return dbContext.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            return dbContext.Categories.Find(id);
        }

        public void Add(Category category)
        {
            dbContext.Categories.Add(category);
            dbContext.SaveChanges();
        }

        public void Remove(Category category)
        {
            dbContext.Categories.Remove(category);
            dbContext.SaveChanges();
        }

        public void Edit(Category category)
        {
            dbContext.Entry(category).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();

        }

}
}
