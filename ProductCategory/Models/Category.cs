using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Models
{
    public class Category
    {
        //Kategoriden ürüne gidiyoruz

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        //Navigation property

        public IList<Product> Products { get; set; }
    }
}
