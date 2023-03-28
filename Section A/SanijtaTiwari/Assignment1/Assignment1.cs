using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("[*] Enter a string: ");
        string input = Console.ReadLine()!;


        string[] words = input.Split(' ');


        foreach(string word in words)
        {
            Console.WriteLine('"' + word + '"');
        }
    }
}
