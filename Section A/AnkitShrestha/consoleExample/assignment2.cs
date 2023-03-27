using System;
using System.IO;


namespace ConsoleExamples {
  public class FileIO {

    public void fileOperation(){
        string path = @"E:\college\semesterVI\dotnet\BscCSIT-2023\Section A\AnkitShrestha\ConsoleExample\test.txt";
    if (!File.Exists(path))
        {
            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("Hello");
                sw.WriteLine("And");
                sw.WriteLine("Welcome");
            }
        }

        // Open the file to read from.
        using (StreamReader sr = File.OpenText(path))
        {
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
    }
    
  }
}

