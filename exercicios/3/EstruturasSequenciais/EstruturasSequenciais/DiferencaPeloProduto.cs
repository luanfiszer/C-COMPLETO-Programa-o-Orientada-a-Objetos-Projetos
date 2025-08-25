namespace EstruturasSequenciais;

public class DiferencaPeloProduto
{
    static void diferencaPeloProduto()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());

        Console.WriteLine((a * b) - (c * d));
    }
}
