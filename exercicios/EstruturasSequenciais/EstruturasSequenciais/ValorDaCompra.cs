using System.Globalization;

namespace EstruturasSequenciais;
public class ValorDaCompra
{
    static void valorDaCompra()
    {
        Console.WriteLine("CALCULADORA DE COMPRAS: ");
        Console.WriteLine("--------------------------");

        Console.Write("Número da peça: ");
        int peca1 = int.Parse(Console.ReadLine());
        Console.Write("Quantidade de peças: ");
        int quantidade1 = int.Parse(Console.ReadLine());
        Console.Write("Preço da peça: ");
        double preco1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine(" ");

        Console.Write("Número da peça: ");
        int peca2 = int.Parse(Console.ReadLine());
        Console.Write("Quantidade de peças: ");
        int quantidade2 = int.Parse(Console.ReadLine());
        Console.Write("Preço da peça: ");
        double preco2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine($"O valor total da compra é: " + ((quantidade1 * preco1) + (quantidade2 * preco2)).ToString("F2", CultureInfo.InvariantCulture));

    }
}
