using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Models
{
    public class Product
    {
        // Üründen Kategoriye gidiyoruz

        public int Id { get; set; }

        public string ImageAdress { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Rating { get; set; }

        public decimal Price { get; set; }

        public double Discount { get; set; }

        public Category Category { get; set; }

        public string ProductInfos { get; set; }

        public int CategoryId { get; set; }


    }
}
