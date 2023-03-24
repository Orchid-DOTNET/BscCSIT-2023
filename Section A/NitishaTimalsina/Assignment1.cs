using System;

namespace Assignment1
{
    class StringEdit
    {
        public static void Main()
        {
            Console.Write("Enter a string: ");
            string value = Console.ReadLine();
            string[] strArray = value.Split(" ");
            foreach(string str in strArray)
            {
                Console.WriteLine('"'+str+'"');
            }
        }
    }
}