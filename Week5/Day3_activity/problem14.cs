using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCodeTemplate
{
    internal class problem14
    {
        static void Main()
        {
            //display whether all products are below Mrp Rs.30 not.
            Product p = new Product();
            List<Product> products = p.GetProducts();
            bool result=products.All(pro => pro.ProMrp > 30);
            Console.WriteLine(result?"All products are > 30": "All products not are >30");
        }
    }
}
