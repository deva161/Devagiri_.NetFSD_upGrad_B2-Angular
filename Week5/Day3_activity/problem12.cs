using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCodeTemplate
{
    internal class problem12
    {
        static void Main()
        {
            // to display Max price. 
            Product p = new Product();
            List<Product> products=p.GetProducts();
            Console.Write(products.Max(pro => pro.ProMrp));

        }
    }
}
