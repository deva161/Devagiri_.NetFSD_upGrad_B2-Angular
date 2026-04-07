using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCodeTemplate
{
    internal class problem6
    {
        static void Main()
        {
            //  sort products in descending order by product Mrp.

            Product p = new Product();
            List<Product> productsData = p.GetProducts();

            var result = productsData.OrderByDescending(pro => pro.ProMrp);
            foreach (var item in result)
            {
                Console.WriteLine($"{item.ProCode}\t{item.ProName}\t{item.ProCategory}\t{item.ProMrp}\t");
            }
        }
    }
}
