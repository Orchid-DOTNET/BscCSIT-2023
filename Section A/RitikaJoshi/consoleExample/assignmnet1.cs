namespace ConsoleExamples
{
    public class StringDoubleQuotes
    {
        public void adddoubleQuotes()
        {
            Console.WriteLine("Enter a string: ");
            string value = Console.ReadLine();
            string[] valArr = value.Split(" ");
            foreach (string val in valArr)
            {
                Console.WriteLine("\"" + val + "\"");
            }
        }
    }
}