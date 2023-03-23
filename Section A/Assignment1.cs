// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace class1
{
    class stringPrint
    {
        public static void Main()
        {
            Console.WriteLine("\n Enter a String: ");
            string value = Console.ReadLine();
            string[] valArr = value.Split(" ");
            for(int i = 0; i < valArr.Length; i++)
            {
                Console.WriteLine('"' + valArr[i] + '"');
            }
        }
    }

}
