using System;
using MultipleInheritence;

public class Calculator : Cal1, Cal2, Cal3, Cal4
{
    public void add(int x, int y)
    {
        int result = x + y;
        Console.WriteLine(result);
    }
    public void subtract(int x, int y)
    {
        int result = x - y;
        Console.WriteLine(result);
    }
    public void multiply(int x, int y)
    {
        int result = x * y;
        Console.WriteLine(result);
    }
    public void divide(int x, int y)
    {
        int result = x / y;
        Console.WriteLine(result);
    }
}




