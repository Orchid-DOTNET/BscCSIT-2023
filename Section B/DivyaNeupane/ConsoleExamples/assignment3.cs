using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Employee
{

   
    int id;
    int age;
    string department;
    string name;

    public override string ToString()
    {
        return id + " " + name + " " + age + " " + department;
    }


    static void Main(string[] args)
    {

        List<Employee> emp = new List<Employee>()
    {
		
		
		new Employee{ id = 101, name = "Sravan",
                    age = 32, department = "HR" },
        new Employee{ id = 102, name = "deepu",
                    age = 15, department = "Development" },
        new Employee{ id = 103, name = "manoja",
                    age = 13, department = "Development" },
        new Employee{ id = 104, name = "Sathwik",
                    age = 12, department = "HR" },
        new Employee{ id = 105, name = "Saran",
                    age = 25, department = "Designing" }
    };

        // Iterate the Employee by selecting Employee
        // name starts with S and age is greater than 23
        IEnumerable<Employee> result = from e in emp
                                       where e.name[0] == 'S' && e.age > 30
                                       select e;

        // Display employee details
        Console.WriteLine("ID Name Age Department");
        Console.WriteLine("+++++++++++++++++++++++++");
        foreach (Employee x in result)
        {

            // Call the to string method
            Console.WriteLine(x.ToString());
        }
    }
}


