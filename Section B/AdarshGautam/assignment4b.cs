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
        Console.WriteLine(calculator.Add(2, 3)); // Output: 5
        Console.WriteLine(calculator.Subtract(5, 2)); // Output: 3
        Console.WriteLine(calculator.Multiply(3, 4)); // Output: 12
        Console.WriteLine(calculator.Divide(8, 2)); // Output: 4
    }
}
}
