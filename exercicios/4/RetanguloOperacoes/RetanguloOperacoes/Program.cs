namespace RetanguloOperacoes;

class Program
{
    static void Main()
    {
        Console.WriteLine("Entre a largura e altura do retangulo: ");

        Retangulo ret = new Retangulo();

        ret.Largura = int.Parse(Console.ReadLine());
        ret.Altura = int.Parse(Console.ReadLine());

        Console.WriteLine($"Area: {ret.Area()}");
        Console.WriteLine($"Perimetro: {ret.Perimetro()}");
        Console.WriteLine($"Area: {ret.Diagonal()}");
    }
}