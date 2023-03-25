using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class stringHandling
    {
        public void stringPrint()
        {
            Console.WriteLine("\n Enter a string: ");
            string val = Console.ReadLine();
            string[] valArr = val.Split(' ');
            for (int i = 0; i < valArr.Length; i++)
            {
                Console.WriteLine('"' + valArr[i] + '"');
            }
        }
    }
}