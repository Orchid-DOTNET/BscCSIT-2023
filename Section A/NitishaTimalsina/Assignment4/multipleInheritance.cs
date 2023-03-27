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

    public int div(int x, int y)
    {
        return x / y;

    }
}

  