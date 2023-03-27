using System;
using MultipleInheritance;
namespace Assignment4
{
    class Calculation : Calc1, Calc2, Calc3, Calc4
    {
        public float a;
        public float b;
        public Calculation(float a, float b)
        {
            this.a = a;
            this.b = b;
        }

        public float Add()
        {
            return this.a + this.b;
        }

        public float Subtract()
        {
            return this.a - this.b;
        }

        public float Multiply()
        {
            return this.a * this.b;
        }

        public float Divide()
        {
            try
            {
                if (this.b == 0)
                {
                    throw new Exception("denominator cannot be zero");
                }
                else
                {
                    return this.a / this.b;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return 0;
            }
        }
    }

   class Menu
    {
      
        // a Menu for Calculation;
        public static void menu_assignment_4()
        {
            
            float a, b;
	    
            Console.Write("\n\n[*] Enter 1st Number: ");
            a = float.Parse(Console.ReadLine());

            Console.Write("\n[*] Enter 2nd Number: ");
            b = float.Parse(Console.ReadLine());

            Console.Write("\n[*] 1) Add 2) Subtract 3) Multiply 4) Divide 5) Exit \n\n [*] Choose an option: ");
            string option = Console.ReadLine();
            Calculation calc = new Calculation(a, b);
            
            switch (option)
            {
                case "1":
                    Console.WriteLine("[*] {0} + {1} = {2}", calc.a, calc.b, calc.Add());
                    break;
                case "2":
                    Console.WriteLine("[*] {0} - {1} = {2}", calc.a, calc.b, calc.Subtract());
                    break;
                case "3":
                    Console.WriteLine("[*] {0} * {1} = {2}", calc.a, calc.b, calc.Multiply());
                    break;
                case "4":
                    Console.WriteLine("[*] {0} / {1} = {2}", calc.a, calc.b, calc.Divide());
                    break;
		case "5":
		    Console.WriteLine("[*] Exiting ... ");
		    System.Environment.Exit(1);
		    break; 
                default:
                    Console.WriteLine("[!] Wrong Option");
                    break;
            }

        }
    }
} 
