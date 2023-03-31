using ConsoleExamples;
using MultipleInhertance;
using ErrorHandlingApplication;
internal class Program
{
    private static void Main(string[] args)
    {
            StringDoubleQuotes stringEdit = new StringDoubleQuotes();
            //Assignment 1
            stringEdit.adddoubleQuotes();

            //Assignment 2
            FileIO file = new FileIO();
            file.fileOperation();

            //Assignment 3
            LinkQExample linkq = new LinkQExample();
            linkq.example();

            //Assignment 4
            Calculate calculator = new Calculate();
            Console.WriteLine(calculator.add(3, 4));

            // Assignment 5
            DivNumbers d = new DivNumbers();
            d.division(25, 0);
            Console.ReadKey();

    }
}
