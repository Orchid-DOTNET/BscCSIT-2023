using System;
using Assignment3;
using Assignment4;
using Assignment5;
namespace ConsoleExamples
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            // StringEdit stringEdit = new StringEdit();
            // //Assignment 1
            // stringEdit.DoubleQuote();
            
            //Assignment3 
            LinqClass linqClass = new LinqClass();
            linqClass.EmployeeFunc();
        //Assignment4
            BasicCal calObj = new BasicCal();
            calObj.BasicCalFunc();

            //Assignment5
            ExceptionHandling exceptionHandling = new ExceptionHandling();
            exceptionHandling.ExceptionFunc();

        }
    }
}