using System;

namespace MultipleInheritance
{

    interface Cal1
    {
        
        void add(int x, int y);

    }

    interface Cal2
    {
        void sub(int x, int y);
    }

    interface Cal3
    {
        void mul(int x, int y);
    }

    interface Cal4
    {
        void div(int x, int y);
    }

    class Calculator : Cal1, Cal2, Cal3, Cal4
    {

        public void add(int x, int y)
        {

            int result1 = x+ y;
            Console.WriteLine("Addition of x and y : " + result1);
        }

        public void sub(int x, int y)
        {
            int result2 = x- y;
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

            Calculator r1 = new Calculator();

            r1.add(2, 1);
            r1.sub(2, 1);
            r1.mul(2, 1);
            r1.div(2, 1);

        }
    }
}