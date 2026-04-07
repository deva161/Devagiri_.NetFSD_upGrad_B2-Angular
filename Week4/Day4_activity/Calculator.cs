using System;


namespace Assignments
{
    internal class Calculator
    {
        static int Add(int a,int b)
        {
            return a + b;
        }
        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static void Main()
        {
            Console.Write("Enter number1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int addResult = Add(num1,num2);
            int subResult = Subtract(num1, num2);

            Console.WriteLine($"Addition = {addResult}\nSubstraction =  {subResult}");
        }
    }
}
