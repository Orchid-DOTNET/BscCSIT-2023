using System;
using System.Collections.Generic;
using System.IO;
public class program{
   public static void Main() {
      using (StreamWriter sw = new StreamWriter("sann.txt")) {
         sw.WriteLine("Hi");
         sw.WriteLine("This is sann");
         sw.WriteLine("What's up");
      }
      int count = File.ReadAllLines("sann.txt").Length;
      Console.WriteLine("Number of lines: "+count);
   }
}