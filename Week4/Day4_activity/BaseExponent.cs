using System;
namespace Assignments
{
    class Program
    {
        static int CalculatePower(int baseNum, int exponent)
        {
            if (exponent == 0)
                return 1;
            if (exponent == 1)
                return baseNum;
            return baseNum * CalculatePower(baseNum, exponent - 1);
        }

        static void Main()
        {
            Console.Write("Enter base: ");
            int baseNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter exponent: ");
            int exponent = Convert.ToInt32(Console.ReadLine());

            int result = CalculatePower(baseNum, exponent);

            Console.WriteLine("Result: " + result);
        }
    }
}
