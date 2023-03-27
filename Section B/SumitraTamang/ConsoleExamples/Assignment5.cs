//c sharp code to implement exceptional handling

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class ExceptionHandling
    {
        public void ExceptionFunc()
        {
            int a = 10, b, c;
            try
            {   
                Console.WriteLine("Enter the value of b");
                b = Convert.ToInt32(Console.ReadLine());

                c = a / b;
                Console.WriteLine("The result of {0} div by {1} is {2}",a,b, c);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("For div by zero Exception caught: {0}", e);
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }
            

            //printing index that is not present

            int[] arr =  { 1, 2, 3, 4, 5 };
            try
            {
                Console.WriteLine(arr[10]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("For array Exception caught: {0}", e);
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }
             Console.ReadLine();
             Console.ReadLine();

        }
    }
}