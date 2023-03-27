using System;

namespace CalculatorProgram
{
    interface ICalculator
    {
        void Add(int a, int b);
        void Subtract(int a, int b);
        void Multiply(int a, int b);
        void Divide(int a, int b);
    }

    class Calculator : ICalculator
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("The sum of {0} and {1} is {2}", a, b, a + b);
        }

        public void Subtract(int a, int b)
        {
            Console.WriteLine("The difference between {0} and {1} is {2}", a, b, a - b);
        }

        public void Multiply(int a, int b)
        {
            Console.WriteLine("{0} multiplied by {1} is {2}", a, b, a * b);
        }

        public void Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Cannot divide by 0");
            }
            else
            {
                Console.WriteLine("{0} divided by {1} is {2}", a, b, a / b);
            }
        }
    }

    class assignment4
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int num1, num2, choice;

            Console.WriteLine("Welcome to the Calculator Program!");

            do
            {
                Console.WriteLine("\nPlease enter the first number: ");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the second number: ");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("\nWhat do you want to do with these numbers?\n1. Add\n2. Subtract\n3. Multiply\n4. Divide\n5. Exit");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        calculator.Add(num1, num2);
                        break;

                    case 2:
                        calculator.Subtract(num1, num2);
                        break;

                    case 3:
                        calculator.Multiply(num1, num2);
                        break;

                    case 4:
                        calculator.Divide(num1, num2);
                        break;

                    case 5:
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

            } while (choice != 5);
        }
    }
}




