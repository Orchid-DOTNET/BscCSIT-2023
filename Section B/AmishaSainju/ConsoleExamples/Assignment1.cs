using System;

class Assignment1
{
    static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string[] words = input.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            words[i] = "\"" + words[i] + "\"";
        }

        string output = string.Join(" ", words);

        Console.WriteLine(output);
    }
}