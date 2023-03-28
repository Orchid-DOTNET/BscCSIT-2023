using System;
using System.Collections.Generic;
using System.Linq;

class assignment3 {
    static void Main(string[] args) {
        // Sample data
        var employees = new [] {
            new { ID = 101, Name = "John", Age = 40 },
            new { ID = 102, Name = "John", Age = 28 },
            new { ID = 107, Name = "John", Age = 25 },
            new { ID = 120, Name = "John", Age = 32 },
            new { ID = 109, Name = "John", Age = 33 },
            new { ID = 103, Name = "John", Age = 33 },
            new { ID = 104, Name = "John", Age = 28 },
            new { ID = 105, Name = "John", Age = 30 }
        };

        // Query to select employees whose age is greater than 30 and order by ID
        var result = employees.Where(e => e.Age > 30).OrderBy(e => e.ID);

        // Display the results
        foreach (var employee in result) {
            Console.WriteLine($"ID: {employee.ID}, Name: {employee.Name}, Age: {employee.Age}");
        }
    }
}
