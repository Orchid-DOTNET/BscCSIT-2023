using System;
using System.IO;

namespace Assignment2
{
    public class  FileLine
  {
        public void counter()
    {
        StreamReader result = new StreamReader("C:\\Users\\lenovo\\Desktop\\dotnet\\BscCSIT-2023\\Section A\\SupriyaShreeBasnyat\\Assignment2.txt");
        int count = 0;
        string line = result.ReadLine();
        while(line != null)
        {
            count++;
            Console.WriteLine(line);
            line = result.ReadLine();

        }
            Console.Write("The number of lines in the file is : " + count);
    } 
  }
}

