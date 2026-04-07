using System;

// Base Class
class Employee
{
    public string Name { get; set; }
    public double BaseSalary { get; set; }

    public Employee(string name, double salary)
    {
        Name = name;
        BaseSalary = salary;
    }

    // Virtual Method
    public virtual double CalculateSalary()
    {
        return BaseSalary;
    }
}

// Derived Class: Manager
class Manager : Employee
{
    public Manager(string name, double salary) : base(name, salary) { }

    public override double CalculateSalary()
    {
        return BaseSalary + (BaseSalary * 0.20); // 20% bonus
    }
}

// Derived Class: Developer
class Developer : Employee
{
    public Developer(string name, double salary) : base(name, salary) { }

    public override double CalculateSalary()
    {
        return BaseSalary + (BaseSalary * 0.10); // 10% bonus
    }
}
