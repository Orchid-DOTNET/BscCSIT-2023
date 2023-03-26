namespace Sagar
{
    public class StringEdit
    {
        public void DoubleQuote()
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