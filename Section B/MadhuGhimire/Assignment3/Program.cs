using System;
using System.Collections.Generic;
using System.Linq;

class Program {
    static void Main(string[] args) {
        List<Employee> employees = new List<Employee> {
            new Employee { ID = 101, Name = "Madhu", Age = 40 },
            new Employee { ID = 102, Name = "Sushant", Age = 28 },
            new Employee { ID = 107, Name = "Darshan", Age = 25 },
            new Employee { ID = 120, Name = "Avishek", Age = 32 },
            new Employee { ID = 109, Name = "Sagar", Age = 33 },
            new Employee { ID = 103, Name = "Adarsh", Age = 33 },
            new Employee { ID = 104, Name = "Nischal", Age = 28 },
            new Employee { ID = 105, Name = "Samir", Age = 30 }
        };

        var results = employees.Where(e => e.Age > 30).OrderBy(e => e.ID);

        foreach (var employee in results) {
            Console.WriteLine("ID: {0}, Name: {1}, Age: {2}", employee.ID, employee.Name, employee.Age);
        }
    }
}

class Employee {
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}
