namespace Assignment1
{
    class StringEdit
    {
        public static void EditString()
        {
            Console.WriteLine("[*] Enter a string:");
            string value = Console.ReadLine();
            string[] valArr = value.Split(" ");
            foreach (string str in valArr)
            {
                Console.WriteLine('"' + value + '"');
            }
        }
    }
       
}