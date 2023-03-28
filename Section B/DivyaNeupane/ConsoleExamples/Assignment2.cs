using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleExamples
{
    public class assignment2
    {
        public static void Main()
        {
            using (StreamWriter sw = new StreamWriter("assignment2.txt"))
            {
                sw.WriteLine("This is demo line 1");
                sw.WriteLine("This is demo line 2");
                sw.WriteLine("This is demo line 3");
            }
            int count = File.ReadAllLines("assignment2.txt").Length;
            Console.WriteLine("Number of lines: " + count);
        }
    }
}


