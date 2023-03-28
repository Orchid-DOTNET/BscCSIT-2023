using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class exceptionHandling
    {
        public void div(int x, int y)
        {
             try
            {
                double result = x / y;
                Console.WriteLine("{0}/{1} = {2}", x, y, result);
            }

            catch(DivideByZeroException) {
                Console.WriteLine("Exception Caught: {0} was divided by 0", x);
            }


        }
    }
}
