
namespace Assignment1
{
    class StringEditing
    {
        public static void Main(string[] args)
            public static void editstring()
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
