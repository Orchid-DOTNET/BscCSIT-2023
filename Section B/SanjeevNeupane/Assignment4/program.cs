class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        double x = 10;
        double y = 5;

        Console.WriteLine($"Addition: {x} + {y} = {calculator.Add(x, y)}");
        Console.WriteLine($"Subtraction: {x} - {y} = {calculator.Subtract(x, y)}");
        Console.WriteLine($"Multiplication: {x} * {y} = {calculator.Multiply(x, y)}");
        Console.WriteLine($"Division: {x} / {y} = {calculator.Divide(x, y)}");

        Console.ReadKey();
    }
}
