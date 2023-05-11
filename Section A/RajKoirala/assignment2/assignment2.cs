using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = @"text.txt"; 
        int count = 0;

        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (sr.ReadLine() != null)
                {
                    count++;
                }
            }
            Console.WriteLine("The file contains {0} lines.", count);
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: {0}", e.Message);
        }
    }
}
