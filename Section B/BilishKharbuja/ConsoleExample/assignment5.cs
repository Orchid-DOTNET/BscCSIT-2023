using System;

namespace ExceptionHandlingDemo
{
    class Assignment5
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 2;
            int result;

            try
            {
                // Attempt to divide num1 by num2, which will throw an exception if num2 is 0
                result = num1 / num2;
            }
            catch (DivideByZeroException ex)
            {
                // Handle the exception by printing an error message
                Console.WriteLine("Error: Cannot divide by 0");
            }
            finally
            {
                // This code will always execute, regardless of whether or not an exception occurs
                Console.WriteLine("Program execution complete.");
            }
        }
    }
}








