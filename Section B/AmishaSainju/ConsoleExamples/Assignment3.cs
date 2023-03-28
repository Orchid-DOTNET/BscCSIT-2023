using System;
using System.Globalization;
using System.Linq;


namespace ConsoleExamples
{
    public class Employee
    {
        int id;
        string name;
        int age;
        string email;
        float salary;

        public override string ToString()
        {
            return id + " " + name + " " + age + " " + salary;
        }

        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
        {
             new Employee {id=115, name="Hari", age=29, salary=90000 },
             new Employee {id=150, name="Sita", age=35, salary=80000 },
             new Employee {id=200, name="Gita", age=34,  salary=70000},
             new Employee {id=265, name="Ravi", age=27,  salary = 100000},
             new Employee {id=300, name="Goma", age=37,  salary= 120000},
            
        };

            IEnumerable<Employee> orderedEmployeeList =
                from emp in employees
                where emp.age > 30
                orderby emp.id
                select emp;

            Console.WriteLine("ID Name Age Salary");
            Console.WriteLine("=====================");
            foreach (Employee o in orderedEmployeeList)
            {
                Console.WriteLine(o.ToString());
            }
            Console.WriteLine("=====================");
        }
    }
}

