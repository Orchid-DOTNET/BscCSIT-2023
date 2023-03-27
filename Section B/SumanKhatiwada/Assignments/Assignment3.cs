using System;
using System.Collections.Generic;
using System.Linq;

public class Employee
{
    int ID;
    string Name;
    int Age;

    public static void displayEmployee()
    {
        List<Employee> employee = new List<Employee>()
        {
            new Employee { ID=4, Name="Suman", Age=19},
            new Employee { ID=3, Name="Ram", Age=32},
            new Employee { ID=6, Name="Shyam", Age=21},
            new Employee { ID=1, Name="Hari", Age=36},
            new Employee { ID=9, Name="Abhishek", Age=19},
            new Employee { ID=2, Name="Amir", Age=39},
        };

        IEnumerable<Employee> Query =
            from emp in employee
            orderby emp.ID
            where emp.Age>30
            select emp;

        Console.WriteLine("ID | Name | Age | Salary");
        Console.WriteLine("-------------------");
        foreach (Employee e in Query)
        {
            Console.WriteLine($"{e.ID} {e.Name} {e.Age}");
        }
    }
}