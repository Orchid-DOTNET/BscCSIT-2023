using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace ConsoleExample
{
    internal class assignment2
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\LENOVO\\Desktop\\Dotnet\\BscCSIT-2023\\Section B\\BilishKharbuja\\ConsoleExample\\assignment2.txt";

            int Count = 0;
           

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (reader.ReadLine() != null)
                {
                    Count++;
                }
            }
            Console.WriteLine($"The file contains {Count} lines.");

           
        }
    }
}

