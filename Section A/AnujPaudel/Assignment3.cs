using System;

namespace Assignment
{

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Post { get; set; }
        public float Salary { get; set; }

        public void show_emp_information()
        {
            Console.Write("[*] Employee Information: \n\n");
            Console.Write("\n[*] ID: {0}", this.Id);
            Console.Write("\n[*] Name: {0}", this.Name);
            Console.Write("\n[*] Age: {0}", this.Age);
            Console.Write("\n[*] Post: {0}", this.Post);
            Console.Write("\n[*] Salary: {0}", this.Salary);
        }
    }
    class Filtering
    {
        public static void filter()
        {
            // Employee Collection
            List<Employee> Employee_List = new List<Employee>()
            {
            new Employee {Id = 5,Name = "Sudip Kc",Age = 31,Email = "narotsit@gmail.com",Post = "Django Developer",Salary = 35000 },
            new Employee { Id = 10, Name  = "Anuj Paudel", Age = 22, Email = "anuj@gmail.com", Post = "DevOps", Salary = 75000 },
              new Employee { Id = 11, Name  = "Anuj Karki", Age = 32, Email = "anuj@gmail.com", Post = "DevOps", Salary = 75000 },
                new Employee { Id = 12, Name  = "Anuj Rai", Age = 52, Email = "anuj@gmail.com", Post = "DevOps", Salary = 75000 },
                  new Employee { Id = 13, Name  = "Anuj Shrestha", Age = 19, Email = "anuj@gmail.com", Post = "DevOps", Salary = 75000 },

            };

            // Performing Query 
            var valid_employee = Employee_List.Where(emp => emp.Age > 30).ToList<Employee>();
            // Ordering Employee List by ID
            var ordered_employee_list = valid_employee.OrderBy(emp => emp.Id);

            // displaying Employee Information Whose Age is Greater than 30
            foreach (Employee emp in ordered_employee_list)
            {
                emp.show_emp_information();
                Console.WriteLine("\n-------------------------------------------------------------\n");
            }
        }

    }

}
 

