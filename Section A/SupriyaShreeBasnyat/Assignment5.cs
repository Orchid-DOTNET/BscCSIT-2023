using System;

namespace Assignment5
{
    public class Divider
    {
        public void divide(int a,int b)
        {
         try
            {
                double result = a / b;
                Console.WriteLine(result);
            }
         catch(DivideByZeroException)
            {
                Console.WriteLine("\n Cannot divide by zero.");
            }
         finally
            {
               
                    Console.WriteLine("\nThe try catch is finished.");
                
                    
            }
        }
    }
}