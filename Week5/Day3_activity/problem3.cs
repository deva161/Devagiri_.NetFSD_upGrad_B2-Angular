using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCodeTemplate
{
    internal class problem3
    {
         static void Main()
        {
            //sort products in ascending order by product code.

            Product p = new Product();
            List<Product> productsData=p.GetProducts();

            var result = productsData.OrderBy(pro => pro.ProCode);
            foreach (var item in result)
            {
                Console.WriteLine($"{item.ProCode}\t{item.ProName}\t{item.ProCategory}\t{item.ProMrp}\t");
            }
        }
    }
}
