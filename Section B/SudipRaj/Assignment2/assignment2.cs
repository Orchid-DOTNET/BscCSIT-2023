//c sharp code to read number of lines in a file
using System;
using System.IO;

namespace assignmnet
{
    class Program
    {
        static void Main()
        {
            string path = @"test.txt";
            int count = 0;
            string line;
            StreamReader file = new StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                count++;
            }
            Console.WriteLine("Number of lines in the file: " + count);
            Console.ReadLine();
        }
    }
}