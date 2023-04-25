using System;
using System.Linq;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        List<string> names = new List<string> {"Alice", "Andrew", "Alex", "Alan", "Anne", "Alicia", "Adam", "Avery", "April"};

        var filteredNames = from name in names
                            where name.StartsWith("A") && name.EndsWith("p")
                            select name;

        Console.WriteLine(string.Join(", ", filteredNames));
    }
}
