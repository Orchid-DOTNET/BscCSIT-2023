
/*Assignment 4 (Simple Calculator using Interfaces and MultipleInheritance)
 
 * Assignment 5 (Exception Handling:DivideByZeroException) 
 
 * Used the calculator from assignment 4 and caught the DivideByZero Exception in the same calculator
*/


using multipleInheritance;

class Calculator : cal1, cal2, cal3, cal4
{
    public int add(int x, int y)
    {
        return x + y;

    }
    public int sub(int x, int y)
    {
        return x - y;

    }
    public int mul(int x, int y)
    {
        return x * y;

    }
    int result = 0;
    public void div(int x, int y)
    {
        try
        {
            result = x / y;
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Exception caught: {0}", e);
        }
        finally
        {
            Console.WriteLine("Result: {0}", result);
        }

    }
}
    

