using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Employee
    {
        public int id;
        public string name;
        public int age;

        public Employee(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

    }

    class EmployeeDetails
    {
        public void empDetails()
        {
            List<Employee> EmployeeList = new List<Employee>()
            {
            new Employee(01, "Smith Koirala", 55),
            new Employee(02, "Jhon Timilsina", 32),
            new Employee(03, "Tiwari Parker", 20)
            };

            var result = from emp in EmployeeList
                         where emp.age > 30
                         orderby emp.id
                         select emp;
            foreach (var emp in result)
            {
                Console.WriteLine("ID: {0}", emp.id);
                Console.WriteLine("Name: {0}", emp.name);
                Console.WriteLine("Age: {0}", emp.age);
            }
        }

    }
}