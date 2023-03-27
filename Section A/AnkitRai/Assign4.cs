using MultipleInheritance;
namespace Assignment4
{
    class Calculation: Calc1, Clac2, Calc3, Calce4
    {
       public float Add(int a , int b)
        {
            return a + b;
        }
        public float Sub(int a ,int b)
        {
            return a - b;

        }
        public float Mul(int a ,int b)
        {
            return a * b;
        }
        public float Div(int a ,int b)
        {
            if (b == 0)
            {
                return a;

            }
            else
            {
                return (a / b);
            }
        }
    }
}