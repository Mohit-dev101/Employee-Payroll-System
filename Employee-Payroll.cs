using System;
using System.Collections.Generic;

// Interface
interface IPayable
{
    double CalculatePay();
}

// Base Class
class Employee : IPayable
{
    public int Id;
    public string Name;
    public double BasicSalary;

    public Employee(int id, string name, double basicSalary)
    {
        Id = id;
        Name = name;
        BasicSalary = basicSalary;
    }

    // Virtual method for Polymorphism
    public virtual double CalculatePay()
    {
        return BasicSalary;
    }

    public virtual void Display()
    {
        Console.WriteLine("Employee ID : " + Id);
        Console.WriteLine("Employee Name : " + Name);
    }
}

// Derived Class
class FullTimeEmployee : Employee
{
    public double Bonus;
    public double HRA;

    public FullTimeEmployee(int id, string name, double basicSalary,
                            double bonus, double hra)
        : base(id, name, basicSalary)
    {
        Bonus = bonus;
        HRA = hra;
    }

    public override double CalculatePay()
    {
        return BasicSalary + Bonus + HRA;
    }

    public override void Display()
    {
        Console.WriteLine("\n----- Full Time Employee -----");
        base.Display();
        Console.WriteLine("Basic Salary : " + BasicSalary);
        Console.WriteLine("Bonus : " + Bonus);
        Console.WriteLine("HRA : " + HRA);
        Console.WriteLine("Total Salary : " + CalculatePay());
    }
}

// Another Derived Class
class PartTimeEmployee : Employee
{
    public int HoursWorked;
    public double HourlyRate;

    public PartTimeEmployee(int id, string name,
                            int hoursWorked,
                            double hourlyRate)
        : base(id, name, 0)
    {
        HoursWorked = hoursWorked;
        HourlyRate = hourlyRate;
    }

    public override double CalculatePay()
    {
        return HoursWorked * HourlyRate;
    }

    public override void Display()
    {
        Console.WriteLine("\n----- Part Time Employee -----");
        base.Display();
        Console.WriteLine("Hours Worked : " + HoursWorked);
        Console.WriteLine("Hourly Rate : " + HourlyRate);
        Console.WriteLine("Total Salary : " + CalculatePay());
    }
}

// Main Class
class Program
{
    static void Main()
    {
        Employee emp1 = new FullTimeEmployee(101, "Mohit", 50000, 8000, 5000);
        Employee emp2 = new PartTimeEmployee(102, "Rahul", 120, 300);
        Employee emp3 = new FullTimeEmployee(103, "Anjali", 60000, 10000, 7000);
        Employee emp4 = new PartTimeEmployee(104, "Priya", 80, 400);

        Console.WriteLine("========== EMPLOYEE PAYROLL ==========");

        emp1.Display();
        Console.WriteLine("--------------------------------------");

        emp2.Display();
        Console.WriteLine("--------------------------------------");

        emp3.Display();
        Console.WriteLine("--------------------------------------");

        emp4.Display();
        Console.WriteLine("--------------------------------------");
    }
}
