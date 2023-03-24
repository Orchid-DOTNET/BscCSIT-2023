using System;

namespace Assignment1
{
    class sampleprogram
    {
        static void Main(string[] args)
        {
            string str1;
            Console.WriteLine("Enter your name");
            str1 = Console.ReadLine();
            string[] name = str1.Split(' ');
            for (int i = 0; i<name.Length; i++)
            {
                Console.Write("\""+name[i]+"\"");
            }
            Console.ReadLine();
        }

    }
}