using System;
using System.IO;

namespace ConsoleExamples
{
    internal class SecondAssignment
    {
        static void Main()
        {
            string filePath = "C:\\Users\\acer\\Documents\\DOTNET\\BscCSIT-2023\\Section B\\BinayaLimbu\\ConsoleApp2\\texts.txt";

            int LineCounter = 0;


            using (StreamReader studyline = new StreamReader(filePath))
            {
                while (studyline.ReadLine() != null)
                {
                    LineCounter++;
                }
            }
            Console.WriteLine($"The file contains {LineCounter} lines.");

        }
    }

}
