using System;


namespace MultipleInheritance
{

    interface Cal1
    {
        
        void add(int x, int y);

    }

    interface Call2
    {
        void sub(int x, int y);
    }

    interface Call3
    {
        void mul(int x, int y);
    }

    interface Call4
    {
        void div(int x, int y);
    }

    class Calculator : Cal1, Call2, Call3, Call4
    {

        
        public void add(int x, int y)
        {

            int result1 = x + y;
            Console.WriteLine("Addition of x and y : " + result1);
        }

        public void sub(int x, int y)
        {
            int result2 = x - y;
            Console.WriteLine("Subtraction of x and y : " + result2);
        }

        public void mul(int x, int y)
        {
            int result3 = x * y;
            Console.WriteLine("Multiplication of x and y : " + result3);
        }

        public void div(int x, int y)
        {
            int result4 = x / y;
            Console.WriteLine("Division of x and y : " + result4);
        }
    }


    class Assigment4
    {
        static void Main(string[] args)
        {

            Calculator c1 = new Calculator();

            c1.add(40, 20);
            c1.sub(40, 20);
            c1.mul(40, 20);
            c1.div(40, 20);

        }
    }
}

