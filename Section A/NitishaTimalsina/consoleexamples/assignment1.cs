
namespace assignment1
{
    class stringEdit
    {
        public static void EditString()
        { 
        Console.Write("[*] Enter a string:");

            string value = Console.ReadLine();
        string[] valArr = value.Split(" ");

        foreach(string val in valArr){
            Console.WriteLine("'"+val+"'");
            }
}
}
    }

