using System;
using System.IO;

namespace Assignment
{
    class FileHandle
    {
        public static void FileLineRead()
        {
            string file_path = "../../../Assignment2.txt";
            try
            {
                int line_count = File.ReadLines(file_path).Count();
                Console.Write($"[*] No of Lines {line_count}");
            }catch(FileNotFoundException exp) {
                Console.WriteLine($"[!] Error Caught {exp.Message}");
             }
        }
    }
}
