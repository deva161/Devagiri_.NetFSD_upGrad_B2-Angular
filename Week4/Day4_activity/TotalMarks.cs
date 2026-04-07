using System;

namespace Assignments
{
    internal class TotalMarks
    {
        public static void CalculateResult(int marks1, int marks2, int marks3, out int Total, out double Average)
        {
            Total = marks1 + marks2 + marks3;
            Average = Total / 3;
        }

        static void Main()
        {
            int marks1, marks2, marks3,Total;
            double Average;
            Console.Write("Enter marks1 : ");
            marks1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter marks2 : ");
            marks2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter marks3 : ");
            marks3 = Convert.ToInt32(Console.ReadLine());

            CalculateResult(marks1, marks2, marks3, out Total, out Average);
            if (Average >= 40)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }

        }
    }
}
