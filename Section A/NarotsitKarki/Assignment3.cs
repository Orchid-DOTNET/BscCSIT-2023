using Assignment3;
using System;
using System.Linq;



namespace Assignment3
{
    public class Employee
    {
        
        private int id;
        private string name;
        public int age;
        private string email;
        private string post;
        private float salary;
        public Employee(int id, string name, int age, string email, string post, float salary)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.email = email;
            this.post = post;
            this.salary = salary;
        }

        public void show_information()
        {
            Console.Write("[*] Employee Information: \n\n");
            Console.Write("\n[*] ID: {0}", this.id);
            Console.Write("\n[*] Name: {0}", this.name);
            Console.Write("\n[*] Age: {0}", this.age);
            Console.Write("\n[*] Post: {0}", this.post);
            Console.Write("\n[*] Salary: {0}", this.salary);
        }

       
    }

    class Run_Assigment
    {
        public static void Run_Assignment_3()
        {
            // Employee Collection
            IList<Employee> Employee_List = new List<Employee>()
            {
            new Employee(1,"Narotsit Karki",31,"narotsit@gmail.com","Django Developer",35000),
            new Employee(2,"Ankit Rai",22,"ankit@gmail.com","Python Developer",45000),
            new Employee(3,"Nitisha Timalsina",35,"nitisha@gmail.com","Digital Marketing",35000),
            new Employee(4,"Raajz Koirala",31,"raajz@gmail.com",".NET Developer",55000),
            new Employee(5,"Milan Khatiwada",25,"milan@gmail.com","PHP Developer",25000),
            new Employee(6,"Suyash Karki",32,"suyash@gmail.com","UI/UX Developer",55000),
            new Employee(7,"Subrat Regmi",22,"subrat@gmail.com","Ruby Developer",65000),
            new Employee(8,"Anuj Paudel",42,"anuj@gmail.com","DevOps",75000),

            };

            // Performing Query 
            var valid_employee = Employee_List.Where(emp => emp.age > 30).ToList<Employee>();

            // displaying Employee Information Whose Age is Greater than 30
            foreach (Employee emp in valid_employee)
            {
                emp.show_information();
                Console.WriteLine("\n-------------------------------------------------------------\n");
            }
        }

    }
}