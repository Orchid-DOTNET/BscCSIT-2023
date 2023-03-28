using System;

class Assignment5
{
    static void Main(string[] args)
    {
        try
        {
            int num1 = 5, num2 = 0;
            int result = num1 / num2;
            Console.WriteLine(result);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
        finally
        {
            Console.WriteLine("End of program.");
        }
    }
}
