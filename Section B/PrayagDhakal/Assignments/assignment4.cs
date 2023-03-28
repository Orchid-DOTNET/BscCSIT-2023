namespace MultipleInheritance
{
    interface calc1
    {
        void add(int a, int b);
    }
    interface cal2
    {
        void sub(int a, int b);
    }
    interface calc3
    {
        void mul(int a, int b);
    }
    interface cal4
    {
        void div(int a, int b);
    }
    class Calculation : calc1, cal2, calc3, cal4
    {
        public int sumResult;
        public void add(int a, int b)
        {
            sumResult = a + b;
        }
        public int subResult;
        public void sub(int a, int b)
        {
            subResult = a - b;
        }
        public int mulResult;
        public void mul(int a, int b)
        {
            mulResult = a * b;
        }
        public int divResult;
        public void div(int a, int b)
        {
            divResult = a / b;
        }

        public class Calculator
        {
            public static void Calculate()
            {
                Calculation c = new Calculation();
                c.add(7, 6);
                c.sub(9, 9);
                c.mul(8, 11);
                c.div(20, 5);
                Console.WriteLine("Sum Result: " + c.sumResult);
                Console.WriteLine("Substraction Result: " + c.subResult);
                Console.WriteLine("Multiplication Result :" + c.mulResult);
                Console.WriteLine("Division Result: " + c.divResult);
            }
        }

    }
}