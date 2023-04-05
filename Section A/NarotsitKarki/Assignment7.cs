using System;
using System.Diagnostics;

namespace Assignment7
{
    class Filtering
    {
        public static List<string> Names = new List<string>{ "Narotsit","aaap", "anup", "Vidit", "aarop","ankop","utkarsh" };
        public static void filter()
        {
            var list_names = Names.Where(s => s.StartsWith("a") && s.EndsWith("p"));

            foreach(var name in list_names)
            {
                Console.WriteLine($"[*] {name}");
            }        
        }
    }
}