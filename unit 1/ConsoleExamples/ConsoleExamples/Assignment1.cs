using System;

namespace assign1{
    class doubleQuote{
        static void main(){
            string inp=Console.ReadLine();
            string[] valArr = inp.Split(' ');
            for(int i=0;i<valArr.Length;i++){
                Console.WriteLine("\""+valArr[i]+"\"");
            }
        }
    }
}