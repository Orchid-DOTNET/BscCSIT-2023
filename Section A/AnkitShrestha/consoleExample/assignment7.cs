namespace Linkq {
    class LinkQ {
        public void example()
        {
           List<string> str =  new List<string>(){"apple", "banana", "coconut", "aheap", "atrip"};  
            var res = from s in str where s.StartsWith('a') && s.EndsWith('p') select s;  
            // var res =  str.Select(s => s.StartsWith('a') && s.EndsWith('p'));
            
            foreach(string i in res)   
            Console.WriteLine(i);
        }
    }
}