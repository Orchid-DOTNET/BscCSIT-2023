using System;

namespace Assignment1
{
    class EditString
    {
        public static void String_Edit()
        {
            string myString ="Dot Net Centric";
            Console.WriteLine(myString);
            string[] newString = myString.Split();
            foreach(string s in newString)
            {
                Console.WriteLine(s);
            }

        }
    }
}