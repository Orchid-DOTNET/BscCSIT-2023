using System;

namespace Sushant{
    class Hello{
        static void Main (string[] args){
            Console.WriteLine("Enter a string: ");
            string value = Console.ReadLine();
            string[] valArr= value.Split(" ");
            foreach (string item in valArr){
                Console.WriteLine('"'+ item+ '"');
            }
            
                
            
        } 
    }
}