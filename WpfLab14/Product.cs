using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLab14
{
    public enum ProductCategories
    {
        Food,
        HomeAppliances
    }
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public ProductCategories ProductCategory { get; set; }

        //public override string ToString()
        //{
        //    return Name;
        //}
    }
}
