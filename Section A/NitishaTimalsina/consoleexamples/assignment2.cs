using System;
using System.IO;

namespace assignment2;

public class FileIO
{
    public static void FileLineCount()
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
