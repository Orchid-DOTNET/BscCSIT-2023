using System;
public class Assignmet5
{
    static void Main()
    {
       
        Console.WriteLine("Enter first number:");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int secondNumber = int.Parse(Console.ReadLine());

        try
        {
            
            int divisionResult = firstNumber / secondNumber;
            Console.WriteLine("Division of two numbers is: " + divisionResult);
        }

        catch (Exception e)
        {
            Console.WriteLine("An exception occurred: " + e.Message);
        }

        finally
        {
          
            Console.WriteLine("Sum of two numbers is: " + (firstNumber + secondNumber));
        }
    }
}