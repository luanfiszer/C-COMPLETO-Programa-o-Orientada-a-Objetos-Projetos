namespace ParamsRefOut;

class Program
{
    static void Main()
    {
        int a = 10;
        Calculator.Triple(ref a);
        Console.WriteLine(a);
    }
}