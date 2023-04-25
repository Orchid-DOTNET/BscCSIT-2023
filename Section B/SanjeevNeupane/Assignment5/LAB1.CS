using System;

class Program
{
    static void Main(string[] args)
    {
        // Variable declaration and initialization
        int num1 = 20;
        int num2 = 8;

        // Basic Input/Output
        Console.WriteLine("Enter a number between 1 and 100:");
        int inputNum = int.Parse(Console.ReadLine());

        if (inputNum < 1 || inputNum > 100)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        Console.WriteLine("You entered: " + inputNum);

        // Selection Statements
        if (inputNum % 2 == 0)
        {
            Console.WriteLine("The number is even");
        }
        else
        {
            Console.WriteLine("The number is odd");
        }

        // Iteration Constructs
        Console.WriteLine("Printing numbers from 10 to 1:");
        for (int i = 10; i >= 1; i--)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        // Constructors
        Person person1 = new Person("Bob", 35);
        person1.Display();

        // Functions and Methods
        int product = MultiplyNumbers(num1, num2);
        Console.WriteLine("Product of " + num1 + " and " + num2 + " is " + product);

        // Exception handling
        try
        {
            int dividend = 15;
            int divisor = 0;
            int result = dividend / divisor;
            Console.WriteLine(result);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }

    // Function to multiply two numbers
    static int MultiplyNumbers(int num1, int num2)
    {
        return num1 * num2;
    }
}

class Person
{
    string name;
    int age;

    // Constructor
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // Method to display person details
    public void Display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}
