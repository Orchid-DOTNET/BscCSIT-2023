using System;

class Program {
    static void Main(string[] args) {
        int numerator = 10;
        int denominator = 0;

        try {
            int result = numerator / denominator;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException ex) {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
