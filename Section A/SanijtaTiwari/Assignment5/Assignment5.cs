using System;

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 0;
        int result;

        try
        {
            result = a / b; 
            Console.WriteLine("Result: " + result); 
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Exception caught: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Finally block executed.");
        }

        Console.ReadLine();
    }
}