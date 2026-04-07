using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCodeTemplate
{
    internal class problem13
    {
        static void Main()
        {
            // to display Min price. 
            Product p = new Product();
            List<Product> products = p.GetProducts();
            Console.Write(products.Min(pro => pro.ProMrp));

        }
    }
}
