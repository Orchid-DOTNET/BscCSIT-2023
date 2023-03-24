﻿
// Assignment 2 File IO operations to read no of lines in a file

using System;
using System.IO;

namespace Assignment2
{
    public class FileIO
    {
        public static void FileLineCount()
        {
            StreamReader file = new StreamReader("D:\\BscCSIT-2023\\Section A\\NarotsitKarki\\Assignment2.txt");
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

