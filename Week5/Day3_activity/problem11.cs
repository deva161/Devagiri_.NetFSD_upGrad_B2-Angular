using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCodeTemplate
{
    internal class problem11
    {
        // to display count of total products with category FMCG.
        static void Main()
        {
            Product p = new Product();
            List<Product> products=p.GetProducts();
            var result=products.Where(p => p.ProCategory == "FMCG");
            Console.WriteLine(result.Count());
        }
    }
}
