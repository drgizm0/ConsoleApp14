using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Department { get; set; }
}

class Program
{
    static void Main()
    {
        // List of Employee (as objects)
        List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "John", Age = 25, Department = "HR" },
            new Employee { Name = "Jane", Age = 30, Department = "Finance" },
            new Employee { Name = "Bob", Age = 35, Department = "IT" },
            new Employee { Name = "Alice", Age = 40, Department = "Finance" },
        };

        // Lambda Expression
        var filteredEmployees = employees.Where(emp => emp.Age > 30 && emp.Department == "Finance").ToList();

        
        foreach (var employee in filteredEmployees)
        {
            
            Console.WriteLine($"Name: {employee.Name}, Age: {employee.Age}, Department: {employee.Department}");

            
            if (employee.Name.StartsWith("J"))
            {
                Console.WriteLine("Name starts with 'J'");
            }

            if (employee.Age > 35)
            {
                Console.WriteLine("Age is greater than 35");
            }

            if (employee.Department == "Finance")
            {
                Console.WriteLine("Department is Finance");
            }

            // You can add more conditions
        }

        Console.ReadLine();
    }
}
