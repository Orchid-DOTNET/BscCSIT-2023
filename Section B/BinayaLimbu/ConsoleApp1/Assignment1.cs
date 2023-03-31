using System;

internal class first
{
    static void Main(string[] args)
    {
        Console.Write("Enter string: ");
        string input = Console.ReadLine();

        string[] StringWords = input.Split(' ');

        for (int i = 0; i < StringWords.Length; i++)
        {
            StringWords[i] = "\"" + StringWords[i] + "\"";
        }

        string output = string.Join(" ", StringWords);

        Console.WriteLine(output);
    }
}
