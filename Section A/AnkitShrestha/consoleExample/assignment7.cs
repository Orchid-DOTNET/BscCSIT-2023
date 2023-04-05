namespace Linkq {
    class LinkQ {
        public void example()
        {
           List<string> str =  new List<string>(){"apple", "banana", "coconut", "aheap", "atrip"};  
        //    List<int> len = new List<int> (){}; 
            var res = from s in str where s.StartsWith('a') && s.EndsWith('p') select s;  
            var lengthOfStr = str.Select(s => s.Length);  
            
            foreach(string i in res)   
            Console.WriteLine(i);

            foreach(int s in lengthOfStr)
                Console.WriteLine(s);
        }
    }
}