using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = @"C:\Users\ACER\Desktop\BscCSIT-2023\Section B\MadhuGhimire\Assignment2\linecount.txt";
        int lineCount = 0;

        using (StreamReader reader = new StreamReader(filePath))
        {
            while (reader.ReadLine() != null)
            {
                lineCount++;
            }
        }
        Console.WriteLine("The file has {0} lines.", lineCount);
        Console.ReadLine();
    }
}






