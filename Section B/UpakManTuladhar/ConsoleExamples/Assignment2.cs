using System;
using System.IO;

namespace ConsoleExamples
{
    internal class Assignment2
    {
        static void Main()
        {
            string filePath = "C:\\Users\\upakt\\Desktop\\6th sem\\.NET\\BscCSIT-2023\\Section B\\UpakManTuladhar\\ConsoleExamples\\Assignment2.txt";

            int Count = 0;

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (reader.ReadLine() != null)
                {
                    Count++;
                }
            }
            Console.WriteLine($"The file contains {Count} lines.");
            
        }
    }

}
