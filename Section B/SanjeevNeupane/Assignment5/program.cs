public namespace Main{

class Program
{
    static void Main(string[] args)
    {
        ErrorHandle name = new ErrorHandle();
        Calculator calculator = new Calculator();

        try
        {
            Console.WriteLine(name.returnName(3));
        }
        catch (IndexOutOfRangeException obj)
        {
            Console.WriteLine(obj.Message);
        }
        finally
        {
            Console.WriteLine("No error completing code");
        }
        try
        {
            double result = calculator.Divide(10, 0);
            Console.WriteLine($"22 / 0 = {result}");
        }
        catch (DivideByZeroException err)
        {
            Console.WriteLine(err.Message);
        }
        finally
        {
            Console.WriteLine("No errors");
        }
        
    }
}
}
