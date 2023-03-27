using System;
using System.IO;

namespace Assignment2
{
    public class FileIO
    {
        public static void FileLineCount()
        {
            StreamReader file = new StreamReader("D:\\BscCSIT-2023\\Section A\\AvishekMajhi\\Assignment2.txt");
            int count = 0;
            string line = file.ReadLine();
            while(line != null)
            {
                count++;
                Console.WriteLine(line);
                line = file.ReadLine();
            }
            Console.WriteLine("\n\n[*] Number of Lines: {0}", count);
            
        }
    }   
}
