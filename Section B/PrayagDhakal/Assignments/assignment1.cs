using System;

namespace Assignment1
{
    class EditString
    {
        public static void StringEdit()
        {
            string myString = "Assignment 1";
            Console.WriteLine(myString);
            string[] newString = myString.Split();
            foreach (string s in newString)
            {
                Console.WriteLine(s);
            }
        }
    }
}