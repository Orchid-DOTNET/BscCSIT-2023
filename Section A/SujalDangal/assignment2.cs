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

        }}}