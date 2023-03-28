
// Assignment 2 File IO operations to read no of lines in a file

using System;
using System.IO;


namespace Assignment2
{
    public class FileIO
    {
        public static void FileLineCount()
        {
            string path = "..\\..\\..\\Assignment2.txt";
            try
            {
                
                int line_count = File.ReadLines(path).Count();
                Console.WriteLine("Number of Lines in file: {0}", line_count);
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("Error File not found");
        
            }
            
        }

    }   
}

