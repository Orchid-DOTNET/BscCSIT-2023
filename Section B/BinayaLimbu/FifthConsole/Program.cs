using System;

class ExceptionHandler
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Second  number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        try
        {
            // Code that may throw an exception goes here.


            int result = num1 / num2;

            Console.WriteLine($"Result: {result}");
        }
        catch (FormatException e)
        {
            // Code to handle FormatException goes here.
            Console.WriteLine("Please enter a valid integer.");
        }
        catch (DivideByZeroException e)
        {
            // Code to handle DivideByZeroException goes here.
            Console.WriteLine("Cannot divide by zero.");
        }
        catch (Exception e)
        {
            // Code to handle any other exception goes here.
            Console.WriteLine("An error occurred: " + e.Message);
        }
        finally
        {
            int sum = num1 + num2;
            Console.WriteLine("The sum of two numbers is:" + sum);
        }

        Console.ReadKey();
    }
}