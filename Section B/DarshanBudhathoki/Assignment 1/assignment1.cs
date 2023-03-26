using System;
namespace first
{
    class program
    {
        static void main()
        {
            Console.WriteLine("enter a string");
            string.stringByUser= Console.ReadLine();
            string[] separated = stringByUser.Split("");
            foreach(string stri in separated){
                Console.WriteLine('"'+stri + '"');
            }
        }
    }
}