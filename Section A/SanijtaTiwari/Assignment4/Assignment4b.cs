using multipleinheritance;

namespace cal{
    class Calculator : Cal1, Cal2, Cal3, Cal4 {
    public int Add(int a, int b) {
        return a + b;
    }

    public int Subtract(int a, int b) {
        return a - b;
    }

    public int Multiply(int a, int b) {
        return a * b;
    }

    public int Divide(int a, int b) {

        return a / b;
    }
}
class Program {
    static void Main(string[] args) {
        Calculator calculator = new Calculator();
        Console.WriteLine(calculator.Add(5, 6)); // Output: 11
        Console.WriteLine(calculator.Subtract(8, 8)); // Output: 0
        Console.WriteLine(calculator.Multiply(9, 10)); // Output: 90
        Console.WriteLine(calculator.Divide(100, 10)); // Output: 10
    }
}
}