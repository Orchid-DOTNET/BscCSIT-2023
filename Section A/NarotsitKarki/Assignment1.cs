// Assignment 1 String Editing

namespace Assignment1
{
    class StringEdit
    {
        public static void EditString()
        {
            Console.Write("[*] Enter a string: ");
            string value = Console.ReadLine();
            string[] valArr = value.Split(" ");
            foreach(string val in valArr ) {
                Console.WriteLine('"'+val+'"');
            }
        }
    }
}
