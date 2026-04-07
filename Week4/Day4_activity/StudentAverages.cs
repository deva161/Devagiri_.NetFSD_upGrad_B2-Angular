using System;

namespace Assignments
{
    class Student
    {
        public double CalculateAverage(int m1, int m2, int m3)
        {
            return (m1 + m2 + m3) / 3;
        }
    }
    internal class StudentAverages
    {
        static void Main()
        {
            Console.Write("Enter m1 Marks : ");
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter m2 Marks : ");
            int m2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter m3 Marks : ");
            int m3 = Convert.ToInt32(Console.ReadLine());
            Student s = new Student();
            double result=s.CalculateAverage(m1, m2, m3);
            if (result >= 80)
            {
                Console.WriteLine($"Average = {result} Grade A");
            }
            else if(result >= 70)
            {
                Console.WriteLine($"Average = {result} Grade B");
            }
            else if(result >= 60)
            {
                Console.WriteLine($"Average = {result} Grade C");
            }
            else if(result >= 50)
            {
                Console.WriteLine($"Average = {result} Grade D");
            }
            else if (result >= 40)
            {
                Console.WriteLine($"Average = {result} Grade E");
            }
            else
            {
                Console.WriteLine($"Average = {result} Fail");
            }

        }
    }
}
