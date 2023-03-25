using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment2
{


    class fileExercise
    {
        public void LineCount()
        {
            
            int count = 0;
            StreamReader file = new StreamReader("myfile.txt");
            Console.WriteLine("File Content : ");
            string line = file.ReadLine();
            while (line != null)
            {
               Console.WriteLine(line);
               count++;
               line = file.ReadLine();
            }
                    
            Console.Write("\n The number of lines in the file is :" + count);
            
        }
    }
}
