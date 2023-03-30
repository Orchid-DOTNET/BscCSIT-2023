using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();

        // Add some employees to the list
        employees.Add(new Employee(1, "John Doe", 25));
        employees.Add(new Employee(2, "Jane Smith", 35));
        employees.Add(new Employee(3, "Bob Johnson", 40));
        employees.Add(new Employee(4, "Alice Williams", 28));
        employees.Add(new Employee(5, "Mark Davis", 45));

        // Filter employees by age and order by ID
        var filteredEmployees = employees
                                .FindAll(e => e.Age > 30)
                                .OrderBy(e => e.Id);

        // Display employee information
        Console.WriteLine("Employees over 30 years old, ordered by ID:\n");
        foreach (var employee in filteredEmployees)
        {
            Console.WriteLine("ID: {0}, Name: {1}, Age: {2}", employee.Id, employee.Name, employee.Age);
        }
    }
}

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public Employee(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }
}
