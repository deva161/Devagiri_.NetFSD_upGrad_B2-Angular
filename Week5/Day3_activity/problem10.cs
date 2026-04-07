using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCodeTemplate
{
    internal class problem10
    {
        //to display count of total products.
        static void Main()
        {
            Product p = new Product();
            List<Product> products=p.GetProducts();
            Console.WriteLine(products.Count());
        }
    }
}
