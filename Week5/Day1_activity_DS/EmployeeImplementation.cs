using System;


namespace Week5Day2
{
    internal class EmployeeImplementation
    {
        static void Main()
        {
            LinkedList<Employee> empList = new LinkedList<Employee>();

            // Insert at Beginning
            empList.AddFirst(new Employee(101, "Alice"));

            // Insert at End
            empList.AddLast(new Employee(102, "Bob"));
            empList.AddLast(new Employee(103, "Charlie"));

            Console.WriteLine("Employee List:");
            Display(empList);

            // Delete by Employee ID
            DeleteById(empList, 102);

            Console.WriteLine("\nAfter Deletion:");
            Display(empList);
        }

        // Delete by ID
        static void DeleteById(LinkedList<Employee> list, int id)
        {
            var current = list.First;

            while (current != null)
            {
                if (current.Value.EmpId == id)
                {
                    list.Remove(current);
                    Console.WriteLine("\nEmployee deleted.");
                    return;
                }
                current = current.Next;
            }

            Console.WriteLine("\nEmployee not found.");
        }

        // Traverse & Display
        static void Display(LinkedList<Employee> list)
        {
            foreach (var emp in list)
            {
                Console.WriteLine($"ID: {emp.EmpId}, Name: {emp.Name}");
            }
        }
    }
}
