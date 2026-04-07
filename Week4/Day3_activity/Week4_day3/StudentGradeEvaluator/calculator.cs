using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Week4_day3
{
    internal class Calculator
    {
        static void Main()
        {
            double result;
            Console.WriteLine("Enter a Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a Operator: ");
            char ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine(result);
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine("Result: " + result);
                    break;

                case '*':
                    result = num1 * num2;
                    Console.WriteLine("Result: " + result);
                    break;

                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine("Result: " + result);
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }
        
        }
    }
}
