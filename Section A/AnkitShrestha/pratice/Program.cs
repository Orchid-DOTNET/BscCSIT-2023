using System;


class Car {
    string name;
    public Car() {
        name = "BMW";
    }
    static string getName() {
        Car myCar = new Car();
        return myCar.name;
    }

    static void Main(string[] argc) {
        string names = getName();
        Console.WriteLine(names);
    }
}



// class Program {
//     static void Main(string[] argc) {
//         Console.WriteLine("Hello World");
//     }
// }