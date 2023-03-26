using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExamples
{
    class Assignment1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("[*] Enter a string: ");
            string value = Console.ReadLine();
            string[] valArr = value.Split(" ");
            foreach (string val in valArr)
            {
                Console.WriteLine('"' + val + '"');
            }

        }
        
        
    }
}
