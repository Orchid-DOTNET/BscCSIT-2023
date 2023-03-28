namespace ConsoleExamples
{
    internal class Assignment1
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("[*] Enter a string: ");
            string value = Console.ReadLine();
            string[] valArr = value.Split(" ");
            foreach (string val in valArr)
            {
                Console.WriteLine('"' + val + '"');
            }
        }
    }
}