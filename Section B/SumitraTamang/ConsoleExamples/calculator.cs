using MultipleInheritance;

namespace Assignment4{
    public class Calculator : ICalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public float Divide(int a, int b)
        {
            return a / b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }
     public class BasicCal
    {
        public void BasicCalFunc()
        {
            Calculator calc = new Calculator();
            Console.WriteLine("Addition: " + calc.Add(10, 20));
            Console.WriteLine("Subtraction: " + calc.Subtract(10, 20));
            Console.WriteLine("Multiplication: " + calc.Multiply(10, 20));
            Console.WriteLine("Division: " + calc.Divide(10, 20));
            Console.ReadLine();
        }
    }

}