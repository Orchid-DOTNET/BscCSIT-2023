using System;
namespace Assignment
{
    class StringEditing
    {
        public static void edit_string()
        {
            Console.Write("Enter a string: ");
            string value = Console.ReadLine();
            string[] valArray = value.Split(" ");
            foreach (string val in valArray)
            {
                Console.WriteLine('"'+val+'"');
            }
        }
    }
}
