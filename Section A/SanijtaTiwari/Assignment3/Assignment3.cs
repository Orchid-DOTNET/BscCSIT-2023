using System;
using System.Collections.Generic;
using System.Linq;

class assignment3 {
    static void Main(string[] args) {
        // Sample data
        var employees = new [] {
            new { ID = 11, Name = "Naruto", Age = 40 },
            new { ID = 12, Name = "Sasuke", Age = 28 },
            new { ID = 17, Name = "Itachi", Age = 25 },
            new { ID = 10, Name = "Sai", Age = 32 },
            new { ID = 19, Name = "Hinata", Age = 33 },
            new { ID = 13, Name = "Sakura", Age = 33 },
            new { ID = 14, Name = "Tsunade", Age = 28 },
            new { ID = 15, Name = "Johan", Age = 30 }
        };

        // Query to select employees whose age is greater than 30 and order by ID
        var result = employees.Where(e => e.Age > 30).OrderBy(e => e.ID);

        // Display the results
        foreach (var employee in result) {
            Console.WriteLine($"ID: {employee.ID}, Name: {employee.Name}, Age: {employee.Age}");
        }
    }
}