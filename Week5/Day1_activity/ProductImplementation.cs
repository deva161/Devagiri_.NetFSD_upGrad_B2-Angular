using System;

namespace Week5Day1
{
    internal class ProductImplementation
    {
        static void Main()
        {
            Electronics e = new Electronics("Laptop", 50000);
            Clothing c = new Clothing("T-Shirt", 2000);

            Console.WriteLine("Electronics: " + e.Name);
            Console.WriteLine("Price after discount: " + e.CalculateDiscount());

            Console.WriteLine();

            Console.WriteLine("Clothing: " + c.Name);
            Console.WriteLine("Price after discount: " + c.CalculateDiscount());
        }
    }
}
