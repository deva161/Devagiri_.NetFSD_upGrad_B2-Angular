using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace LinqCodeTemplate
{
    internal class product15
    {
        static void Main()
        {
            //whether any products are below Mrp Rs.30 not.
            Product p = new Product();
            List<Product> products = p.GetProducts();
            var result = products.Any(pro => pro.ProMrp > 30);

            Console.WriteLine(result?"There is a product >30 ": "There is NO product >30");


        }
    }
}
