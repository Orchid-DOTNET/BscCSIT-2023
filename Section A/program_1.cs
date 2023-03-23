namespace Net_Centric_Compting
{
    class StringEdit
    {
        public static void Main()
        {
            Console.WriteLine("[*] Enter a string: ");
            string value = Console.ReadLine();
            string[] valArr = value.Split(" ");
            foreach(string val in valArr ) {
                Console.WriteLine('"'+val+'"');
            }
        }
    }
}
