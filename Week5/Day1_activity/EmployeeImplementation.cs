using System;

namespace Week5Day1
{
    internal class EmployeeImplementation
    {
        static void Main()
        {
            Manager m = new Manager("John", 50000);
            Developer d = new Developer("Alex", 40000);
            Console.WriteLine("Manager Salary: " + m.CalculateSalary());
            Console.WriteLine("Developer Salary: " + d.CalculateSalary());
        }




    }
}
