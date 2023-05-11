using System;
// implementing try , catch and finally statement
namespace Assignment5
{
    
    //Creating a  Custom error class by inheriting the Exception base class
    class ZeroDivisionException : Exception
    {
        // using overloaded version of the constructor that takes error message as an argument
        public ZeroDivisionException(string Message): base(Message)
        {

        }
    }
    class Divison
    {
        public static void divide(int x,int y)
        {
            try
            {
                if(y == 0)
                { 
                    // throwing a custom error 
                    throw new ZeroDivisionException("[!] Denominator Cannot be zero");
                }
                Console.WriteLine($"\n[*] {x} / {y} = {x / y}");
            }catch(ZeroDivisionException exc)
            {
                Console.WriteLine($"\n[!] Error Occurred \n{exc.Message}");
            }
            finally
            {
                Console.WriteLine($"\n[*] Numerator = {x} and Denomintor = {y}");
            }
        } 
    }
}