
using System;
using System.Collections.Generic;
using System.IO;
public class newProgram {
   public static void Main() {
      using (StreamWriter sw = new StreamWriter("hello.txt")) {
         sw.WriteLine("This is demo line 1");
         sw.WriteLine("This is demo line 2");
         sw.WriteLine("This is demo line 3");
      }
      int count = File.ReadAllLines("hello.txt").Length;
      Console.WriteLine("Number of lines: "+count);
   }
}