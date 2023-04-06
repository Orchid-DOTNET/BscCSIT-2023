using System;

namespace Assignment7
{
    class Filter_Name
    {
        public static List<string> Names = new List<string> { "Vidit", "Narotsit", "aarop", "anup", "Utkarsh" };
        public static void filter_name()
        {
            var list_names = Names.Where(s => s.StartsWith("a") && s.EndsWith("p"));
                foreach(var name in list_names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
