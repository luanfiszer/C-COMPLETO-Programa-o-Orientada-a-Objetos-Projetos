namespace Pares;

class Program
{
    static void Main()
    {
        Console.WriteLine("Quantos números quer analisar?");
        int nNumbers = int.Parse(Console.ReadLine());

        List<int> numbers = new List<int>();
        
        for (int i = 0; i < nNumbers; i++)
        {
            Console.WriteLine($"DIGITE O NUMERO {i + 1}");
            int number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }

        List<int> Pairs = new List<int>();

        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                Pairs .Add(number);
            }
        }

        Console.WriteLine("Os pares são: ");

        foreach (int number in Pairs)
        {
            Console.WriteLine(number);
        }
    }
}