using System;

namespace Week5Day2
{
    class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }

        public Employee(int id, string name)
        {
            EmpId = id;
            Name = name;
        }
    }
}
