

namespace assignment7
{ 
    class Student
    {

        public void Example() {
           
            {

                List<String> names = new List<string>()
        {
            "Nitisha",
            "Supriya",
            "Subrat",
            "Tulip",
            "Sanjita",
            "Raj",
            "Ahllip",
            "Anup"

        };
                var result = from name in names
                             where name.StartsWith("A") && name.EndsWith("p")

                             select name;
                foreach (var name in result)
                {
                    Console.WriteLine(name);
                }
            }
        }

    }
}