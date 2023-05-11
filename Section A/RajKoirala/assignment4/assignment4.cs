
namespace MultipleInheritance
{
    interface cal1
    {
        public int add(int x, int y);
    }
    interface cal2
    {
        public int sub(int x, int y);
    }
    interface cal3
    {
        public int mul(int x, int y);
    }
    interface cal4
    {
        public int div(int x, int y);
    }
    class Calculator : cal1, cal2, cal3, cal4
    {
        int r1, r2, r3, r4;
        public int add(int x, int y)
        {
            r1 = x + y;
            return r1;

        }
        public int sub(int x, int y)
        {
            r2 = x - y;
            return r2;
        }
        public int mul(int x, int y)
        {
            r3 = x * y;
            return r3;
        }
        public int div(int x, int y)
        {
            r4 = x / y;
            return r4;
        }
    }

    class Run_Assignment
    {
        public static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            int a = 12, b = 32;
            Console.WriteLine("{0} + {1} = {2}", a, b, calc.add(a, b));
            Console.WriteLine("{0} - {1} = {2}", a, b, calc.sub(a, b));
            Console.WriteLine("{0} * {1} = {2}", a, b, calc.mul(a, b));
            Console.WriteLine("{0} / {1} = {2}", a, b, calc.div(a, b));

        }

    }

}

