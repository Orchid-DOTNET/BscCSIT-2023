using System;


namespace MultiInheritance
{

    interface Cal1
    {

        void add(int a, int b);

    }

    interface Call2
    {
        void sub(int a, int b);
    }

    interface Call3
    {
        void mul(int a, int b);
    }

    interface Call4
    {
        void div(int a, int b);
    }

    class Calculator : Cal1, Call2, Call3, Call4
    {


        public void add(int a, int b)
        {

            int result1 = a + b;
            Console.WriteLine("Addition of a and b : " + result1);
        }

        public void sub(int a, int b)
        {
            int result2 = a - b;
            Console.WriteLine("Subtraction of a and b : " + result2);
        }

        public void mul(int a, int b)
        {
            int result3 = a * b;
            Console.WriteLine("Multiplication of a and b : " + result3);
        }

        public void div(int a, int b)
        {
            int result4 = a / b;
            Console.WriteLine("Division of a and b : " + result4);
        }
    }


    class Computation
    {
        static void Main(string[] args)
        {

            Calculator c1 = new Calculator();

            c1.add(100, 200);
            c1.sub(400, 300);
            c1.mul(4, 20);
            c1.div(50, 25);

        }
    }
}

