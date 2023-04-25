using System;

namespace MyNamespace
{
    class MyProgram
    {
        static void Main(string[] args)
        {
            string filePath = @"myFile.txt";
            int lineCount = 0;

            string[] lines = System.IO.File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                lineCount++;
            }

            Console.WriteLine("The file " + filePath + " contains " + lineCount + " lines.");
            Console.ReadLine();
        }
    }
}
