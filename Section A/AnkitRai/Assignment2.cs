using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = @"E:\text.txt"; 

        try
        {
            int count = File.ReadLines(filePath).Count();
            Console.WriteLine("The file contains {0} lines.", count);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: {0}", e.Message);
        }
    }
}

