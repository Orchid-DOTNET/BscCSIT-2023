namespace ConsoleExamples
{
    public class LinkQExample
    {
        public void example()
        {
           int[] nums = new int[] {0,1,2};  
            var res = from a in nums where a < 3 orderby a select a;  
            foreach(int i in res)   
            Console.WriteLine(i);
        }
    }
}