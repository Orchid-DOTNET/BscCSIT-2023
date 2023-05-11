//using System;
//using System.Collections.Generic;
//using System.Linq;

namespace Linqsample1
{
    class Employee
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
              new Employee(){ID= 101, Name= "John", Age= 40},
              new Employee {ID= 102, Name= "Ankur", Age= 28},
              new Employee {ID= 107, Name= "Sudin", Age= 25},
              new Employee  {ID= 120, Name= "Abhisek", Age= 32},
              new Employee  {ID= 109, Name= "Amit", Age= 33},
              new Employee  {ID= 103, Name= "Prince", Age= 33},
              new Employee {ID= 104, Name= "Bibek", Age= 28},
              new Employee {ID= 105, Name= "Ankit", Age= 30}
            };
            var result = from emp in employees
                         where emp.Age > 30
                         orderby emp.ID
                         select emp;

            foreach (var emp in result)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Age: {2}", emp.ID, emp.Name, emp.Age);
            }

            Console.ReadLine();
        }
    }
}
