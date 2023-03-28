using System;
using System.Linq;

namespace Assignment3
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string department { get; set; }
    }
    public class Finder
    {
        public void display()
        {
            List<Employee> emp = new List<Employee>()
    {


        new Employee{ id = 101, name = "Nitisha",
                      age = 32, department = "HR" },
        new Employee{ id = 102, name = "Supriya",
                      age = 35, department = "Development" },
        new Employee{ id = 103, name = "Sanjita",
                      age = 23, department = "Development" },
        new Employee{ id = 104, name = "Narotsit",
                      age = 22, department = "HR" },
        new Employee{ id = 105, name = "Ankit",
                      age = 25, department = "Designing" }
    };

            var result = from e in emp
                         where e.age > 30
                         orderby e.id
                         select e;
            Console.WriteLine("Employee with age > 30:  \n");
            foreach (var x in result)
            {


                Console.WriteLine(x.id + " " + x.name + " " +x.age + " " + x.department + "\n");
            }


        }
    }
}