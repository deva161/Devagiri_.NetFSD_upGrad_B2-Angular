using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCodeTemplate
{
    internal class problem9
    {
        static void Main()
        {
            //to display product detail with highest price in FMCG category.

            Product p = new Product();
            List<Product> productsData = p.GetProducts();

            var result = productsData.Where(pro => pro.ProCategory=="FMCG");
            var highest_price = result.Max(r => r.ProMrp);
            Console.WriteLine(highest_price);
        }
    }
}
