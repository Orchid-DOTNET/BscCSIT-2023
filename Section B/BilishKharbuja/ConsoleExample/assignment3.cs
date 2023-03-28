using System;
using System.Globalization;
using System.Linq;
//Assigment 3 to display the Employee Details Whose Age is Greater Than 30 Order by ID

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
             new Employee {id=101, name="Bilish Kharbuja", age=28, email="biliskharbuja@gmail.com", salary=1000 },
             new Employee {id=120, name="Bivek Chaudary", age=26, email="bivekchaudary@gmail.com", salary=2000 },
             new Employee {id=106, name="Prayag Dhakal", age=38, email="dhakalprayag@gmail.com", salary=3000},
             new Employee {id=116, name="Binaya Limbu", age=31, email="binaya@gmail.com", salary = 4000},
             new Employee {id=123, name="Sudip Kc", age=33, email="sudipkc@gmail.com", salary=5000}
        };

            IEnumerable<Employee> orderedEmployeeList =
                from emp in employees
                where emp.age > 30
                orderby emp.id
                select emp;

            Console.WriteLine("ID  Name  Age  Salary");
            Console.WriteLine("=====================");
            foreach (Employee o in orderedEmployeeList)
            {
                Console.WriteLine(o.ToString());
            }
            Console.WriteLine("=================");
        }
    }
}

