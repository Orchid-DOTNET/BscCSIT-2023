using System;

class Program
{
    static void Main(string[] args)
    {
        int numerator = 10;
        int denominator = 0;

        try
        {
            int result = numerator / denominator;
            Console.WriteLine("Result of division: {0}", result);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Exception caught: {0}", ex.Message);
        }
        finally
        {
            Console.WriteLine("Finally block executed.");
        }

        Console.WriteLine("Program continued.");
    }
}
