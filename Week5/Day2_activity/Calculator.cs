using System;
using System.Collections.Generic;
using System.Xml.Linq;


namespace StudentRecords
{
    internal class Calculator
    {
        static void Main()
        {
            Console.WriteLine("Enter numerator : ");
            double numerator = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter denominator : ");
            double denominator = Convert.ToInt32(Console.ReadLine());

            try
            {
                double result=numerator / denominator;
                Console.WriteLine(result);
            }
            catch(DivideByZeroException ex)
            {
                
                Console.WriteLine("Cannot divide by zero");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Operation Executed Successfully");
            }
        }
    }
}
