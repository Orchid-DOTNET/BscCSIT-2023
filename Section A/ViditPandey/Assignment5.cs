using System;

namespace Assignment5
{
    class ExceptionHandling
    {

        public static void divide(int x ,int y)
        {
            float result;
            try
            {
                result = x / y;
                Console.WriteLine($"{x}/{y} = {result}");
            }catch(DivideByZeroException div)
            {
                Console.WriteLine(div.Message);
            }
            finally
            {
                Console.WriteLine($"Numerator = {x} and Denominator = {y}");
            }
        }
    }

}