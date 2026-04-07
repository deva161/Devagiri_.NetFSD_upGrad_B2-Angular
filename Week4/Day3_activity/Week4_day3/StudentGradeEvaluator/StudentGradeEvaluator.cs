using System;

namespace StudentGradeEvaluator
{
    internal class StudentGradeEvaluator
    {
        static void Main()
        {
            string name;
            int marks;

            Console.WriteLine("enter name :");
            name = Console.ReadLine();

            Console.WriteLine("enter marks :");
            marks = Convert.ToInt32(Console.ReadLine());
            if(marks<0 || marks > 100)
            {
                Console.WriteLine("Invalid Marks");
                
            }
            else if (marks >= 90)
            {
                Console.WriteLine("Student : " + name + "Grade: A");

            }
            else if (marks >= 75)
            {
                Console.WriteLine("Student: " + name + " Grade: B");
            }
            else if (marks >= 60)
            {
                Console.WriteLine("Student: " + name + " Grade: C");
            }
            else if (marks >= 40)
            {
                Console.WriteLine("Student: " + name + " Grade: D");
            }
            else
            {
                Console.WriteLine("Student: " + name + " Grade: Fail");
            }

        }
    }
}
