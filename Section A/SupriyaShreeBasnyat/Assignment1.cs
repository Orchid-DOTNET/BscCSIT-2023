namespace Assignment1
{
    class stringToArray
    {
        public void converter()
        {
            Console.WriteLine("Enter a string:");
            string value = Console.ReadLine();
            string[] values = value.Split(' ');
            foreach (string a in values)
            {
                Console.WriteLine('"' + a + '"');
            }


        }
    }
}