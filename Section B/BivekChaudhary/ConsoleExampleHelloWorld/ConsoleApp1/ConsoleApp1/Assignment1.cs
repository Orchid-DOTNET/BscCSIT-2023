
namespace SplitingString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[*] Enter a string: ");
            string value = Console.ReadLine();
            string[] valArr = value.Split(" ");
            foreach (string val in valArr)
            {
                Console.WriteLine(val);
            }
           
        }
    }
}
