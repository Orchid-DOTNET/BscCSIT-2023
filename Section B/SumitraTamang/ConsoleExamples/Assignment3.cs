using System;
namespace Assignment3 
{
    public class Employee
    {
        public int id;
        public string name;
        public int age;

    //constructor
            public Employee(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

    }
    public class LinqClass
    {
        public void EmployeeFunc()
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee(1, "John", 25));
            empList.Add(new Employee(2, "Ram", 36));
            empList.Add(new Employee(3, "Suman", 27));
            empList.Add(new Employee(4, "Sudip", 38));


            var result = from emp in empList
                         where emp.age > 30
                         orderby emp.id
                         select emp;
            
            foreach (var employee in result)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Age: {2}", employee.id, employee.name, employee.age);
            }
            Console.ReadLine();
                                                  ;
        }
        
    }
}