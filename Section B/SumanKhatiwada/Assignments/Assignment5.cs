using System;


class ErrorHandling
{
    public static void HandlingError()
    {
        int x = 0;
        int y = 10;

        try
        {
            int z = y / x;
            Console.WriteLine("Division Result: " + z);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error has occurred: " + ex.Message);
        }
        finally
        {
            Console.WriteLine($"Dividend: {y} and Divisior: {x}");
        }
    }
}