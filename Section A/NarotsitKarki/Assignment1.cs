// Assignment 1 String Editing

namespace Assignment1
{
    class StringEdit
    {
        public static void EditString()
        {
            Console.Write("[*] Enter a string: ");

            string value = Console.ReadLine();
            // split the string at space and store it in array
            string[] valArr = value.Split(" ");
            
            // loop through string array after splitting
            foreach(string val in valArr ) {
                Console.WriteLine('"'+val+'"');
            }
        }
    }
}
