using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Employee
{
    int ID;
    string Name;
    int Age;
    int Salary;

    public override string ToString()
    {
        return ID +"" +Name +""+Age +""+Salary;
    }

    public static void myFunction()
    {
        List<Employee> employee =new List<Employee>()
        {
            new Employee { ID=101, Name="Saroj", Age=23, Salary =40000},
            new Employee { ID=102, Name="Bibek", Age=24,Salary =40000},
            new Employee { ID=103, Name="Sanjeev", Age=65,Salary =40000},
            new Employee { ID=104, Name="Sudip", Age=54,Salary =40000},
            new Employee { ID=105, Name="Samir", Age=35,Salary =40000},

        };

        IEnumerable<Employee>Query =
            from emp in employee
            where emp.Age>30 
            select emp;

        Console.WriteLine("ID Name Age Salary");
        Console.WriteLine("-------------------");
        foreach (Employee e in Query)
        {
            Console.WriteLine(e.ToString());
        }
    }
}
