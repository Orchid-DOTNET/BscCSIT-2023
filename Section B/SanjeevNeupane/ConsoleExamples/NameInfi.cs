public namespace Error
{
    

class ErrorHandle
{
    private string[] name = { "ram", "hari", "sita" };

    public string returnName(int pos)
    {
        if (pos < 0 || pos >= name.Length)
        {
            throw new IndexOutOfRangeException($"Out of range  index  {index}.");
        }
        return name[pos];
    }
}
class Calculator
{
    public double Divide(double x, double y)
    {
        if (y == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return x / y;
    }
}
}
