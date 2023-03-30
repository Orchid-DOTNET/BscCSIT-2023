using System;

interface IAddition
{
    int Add(int a, int b);
}

interface ISubtraction
{
    int Subtract(int a, int b);
}

interface IMultiplication
{
    int Multiply(int a, int b);
}

interface IDivision
{
    int Divide(int a, int b);
}

class Calculator : IAddition, ISubtraction, IMultiplication, IDivision
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public int Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }

        return a / b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        Console.WriteLine("5 + 3 = {0}", calculator.Add(5, 3));
        Console.WriteLine("5 - 3 = {0}", calculator.Subtract(5, 3));
        Console.WriteLine("5 * 3 = {0}", calculator.Multiply(5, 3));
        Console.WriteLine("5 / 3 = {0}", calculator.Divide(5, 3));
    }
}
