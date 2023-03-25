using System;


namespace assignmnet
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            foreach (string word in words)
            {
                Console.Write("\"" + word + "\" ");
            }
            Console.ReadLine();
        }
    }
}
