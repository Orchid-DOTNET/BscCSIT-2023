// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = @"D:\a2.txt";

        try
        {
            int count = File.ReadLines(filePath).Count();

            Console.WriteLine("The file '{0}' lines.", count);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File Not Found!!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
