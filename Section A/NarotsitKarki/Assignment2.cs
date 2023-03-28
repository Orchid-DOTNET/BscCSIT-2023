
// Assignment 2 File IO operations to read no of lines in a file

using System;
using System.IO;


namespace Assignment2
{
    public class FileIO
    {
        public static void FileLineCount()
        {
            
            try
            {
                
                int line_count = File.ReadLines("D:\\BscCSIT-2023\\Section A\\NarotsitKarki\\Assignment2.txt").Count();
                Console.WriteLine("[*] No of Lines : {0}", line_count);
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("[!] File Not Found");
        
            }
                /*
            StreamReader file = new StreamReader("D:\\BscCSIT-2023\\Section A\\NarotsitKarki\\Assignment2.txt");
            string line = file.ReadLine();
            while(line != null)
            {
                count++;
                Console.WriteLine(line);
                line = file.ReadLine();
            }
            Console.WriteLine("\n\n[*] Number of Lines: {0}", count);
            */
        }

    }   
}

