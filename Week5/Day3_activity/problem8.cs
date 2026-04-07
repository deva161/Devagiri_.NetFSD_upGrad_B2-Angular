using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCodeTemplate
{
    internal class problem8
    {
        static void Main()
        {
            //to display products group by product Mrp. 

            Product p = new Product();
            List<Product> productsData = p.GetProducts();

            var result = productsData.GroupBy(pro => pro.ProMrp);

            foreach (var item in result)
            {
                Console.WriteLine($"The Group of : {item.Key}\n");
                foreach (var value in item)
                {
                    Console.WriteLine($"\t{value.ProName}");
                }
                Console.WriteLine();

            }
        }
        
    }
}
