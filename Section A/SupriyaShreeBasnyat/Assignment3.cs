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
            public static void main() {
            IList<Employee> emp = new List<Employee>()
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

            IEnumerable<Employee> result = from e in emp
                                           where e.age > 30
                                           select e;
            Console.WriteLine("Employee with age > 30 ")
            foreach (Employee x in result)
            {

                
                Console.WriteLine(x.ToString);
            }


        }
    }
}

