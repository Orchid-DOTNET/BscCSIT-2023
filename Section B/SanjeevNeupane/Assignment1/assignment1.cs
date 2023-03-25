using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        string[] words = inputString.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            words[i] = "\"" + words[i] + "\"";
        }

        Console.WriteLine("Formatted words:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        Console.ReadKey();
    }
}
