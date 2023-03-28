using System;

public class LineRead
{

    public static void ReadLine()
    {
        string filePath = "file.txt";
        int lineCount = 0;

        using (StreamReader reader = new StreamReader(filePath))
        {
            while (reader.ReadLine() != null)
            {
                lineCount++;
            }
        }

        Console.WriteLine($"Total number of lines = {lineCount}");
    }
}