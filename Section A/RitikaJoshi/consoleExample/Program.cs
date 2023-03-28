// namespace ConsoleExamples
// {
//     internal class Program
//     {
//         private static void Main(string[] args)
//         {
//             StringDoubleQuotes stringEdit = new StringDoubleQuotes();
//             //Assignment 1
//             stringEdit.adddoubleQuotes();

//             //Assignment 2
//             FileIO file = new FileIO();
//             file.fileOperation();

//             //Assignment 3
//             LinkQExample linkq = new LinkQExample();
//             linkq.example();


//         }
//     }
// }

// Assignment 4

namespace MultipleInhertance {
    internal class Program {
        private static void Main() {
            Calculate calculator = new Calculate();
            Console.WriteLine(calculator.add(3, 4));
        }
    }
}