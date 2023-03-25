using System;

namespace assignment1{
    class program{
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
