namespace SplitString
{
    class Program
    {
        static void Main(String[] args)
        {
            //string 
            String myString = "dotnet Centric Computing";
            String[] newString = myString.Split(" ");
            //loop
            foreach (String s in newString)
            {
                Console.WriteLine(s);
            }

        }
    }
}