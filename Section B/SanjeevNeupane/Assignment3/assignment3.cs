using System;
using System.Linq;

class Staff {
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

class LINQProgram {
    static void Main(string[] args) {
        Staff[] staffs = new Staff[] {
            new Staff { ID = 101, Name = "Ram", Age = 37 },
            new Staff { ID = 201, Name = "Shyam", Age = 22 },
            new Staff { ID = 301, Name = "Hari", Age = 25 },
            new Staff { ID = 401, Name = "Suman", Age = 20 },
            new Staff { ID = 501, Name = "Raj", Age = 39 },
        };


        var result = from staff in staffs
                     where staff.Age > 30
                     orderby staff.ID ascending
                     select staff;

        Console.WriteLine("List of staffs whose age is greater than 30:");
        foreach (var staff in result) {
            Console.WriteLine($"ID: {staff.ID}, Name: {staff.Name}, Age: {staff.Age}");
        }
    }
}
