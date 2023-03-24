using System;
namespace SplitString
{
    class Program
    {
        static void Main(string[] args)
        {
            //string 
            string myString= "dotnet Centric Computing";
            string[] newString =  myString.Split(" ");
            //loop
            foreach(string s in newString)
            {
                Console.WriteLine(s);
            }
            
        }
    }
}