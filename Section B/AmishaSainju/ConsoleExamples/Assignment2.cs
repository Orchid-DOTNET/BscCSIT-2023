using System;
using System.IO;

namespace ConsoleExamples
{
    internal class Assignment2
    {
        static void Main()
        {
            string filePath = "D:\\NET\\BscCSIT-2023\\Section B\\AmishaSainju\\ConsoleExamples\\Assignment2.txt";

            int Counter = 0;
            

            using (StreamReader studyline = new StreamReader(filePath))
            {
                while (studyline.ReadLine() != null)
                {
                    Counter++;
                }
            }
            Console.WriteLine($"The file contains {Counter} lines.");
           
        }
    }

}

