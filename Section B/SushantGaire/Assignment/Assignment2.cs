using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "C:\\Users\\acer\\Desktop\\desktop2\\react projects\\quizzzz\\public\\robots.txt";
        int lineCount = 0;

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (reader.ReadLine() != null)
                {
                    lineCount++;
                }
            }

            Console.WriteLine("The number of lines in the file is: {0}", lineCount);
        }
        catch (IOException e)
        {
            Console.WriteLine("An error occurred: {0}", e.Message);
        }
    }
}
