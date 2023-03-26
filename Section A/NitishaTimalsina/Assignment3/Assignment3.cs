using System;
using System.Linq;


public class Assignment3
{
    public static void Main()
    {

        IList<Employee> employeeList = new List<Employee>() {
                new Employee() { EmployeeID = 101, EmployeeName = "Nitisha", Age = 21} ,
                new Employee() { EmployeeID = 201, EmployeeName = "Supriya",  Age = 21 } ,
                new Employee() { EmployeeID = 301, EmployeeName = "Subrat",  Age = 33 } ,
                new Employee() { EmployeeID = 401, EmployeeName = "Raj" , Age = 35} ,
                new Employee() { EmployeeID = 501, EmployeeName = "Narotsit" , Age = 21 },
                new Employee() { EmployeeID = 601, EmployeeName = "Ankit" , Age = 36} ,
            };

        var officeEmployee = from s in employeeList
                              where s.Age > 30
                              select s;
        Console.WriteLine("Employee above 30:");

        foreach (Employee std in officeEmployee)
        {
            
            Console.WriteLine(std.EmployeeID+" "+std.EmployeeName+" "+std.Age);
            

        }
    }
}


public class Employee
{

    public int EmployeeID {
        get;
        set;
    }
    public string EmployeeName {
        get;
        set;
    }
    public int Age {  
        get; 
        set;
    }

}