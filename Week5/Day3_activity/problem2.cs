using System;


namespace LinqCodeTemplate
{
    internal class problem2
    {
        static void Main()
        {
            Product p = new Product();
            List<Product> products=p.GetProducts();

            // search all product whose category is Grain.

            var result = products.Where(pro => pro.ProCategory == "Grain");
            foreach (var item in result)
            {
                Console.WriteLine($"{item.ProCode}\t{item.ProName}\t{item.ProCategory}\t{item.ProMrp}\t");
            }
        }
    }
}
