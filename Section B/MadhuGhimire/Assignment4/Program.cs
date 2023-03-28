//Write a program to implement multiple inheritance using interfaces.
using System;

interface Addition
{
    int Add(int a, int b);
}

interface Subtraction
{
    int Subtract(int a, int b);
}

interface Multiplication
{
    int Multiply(int a, int b);
}

interface Division
{
    int Divide(int a, int b);
}

class Calculator : Addition, Subtraction, Multiplication, Division
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
            throw new DivideByZeroException("Cannot divide by zero");
        }
        return a / b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();

        int resultAdd = calc.Add(5, 10);
        Console.WriteLine("5 + 10 = " + resultAdd);

        int resultSubtract = calc.Subtract(15, 5);
        Console.WriteLine("15 - 5 = " + resultSubtract);

        int resultMultiply = calc.Multiply(5, 10);
        Console.WriteLine("5 * 10 = " + resultMultiply);

        int resultDivide = calc.Divide(20, 5);
        Console.WriteLine("20 / 5 = " + resultDivide);

    }
}

