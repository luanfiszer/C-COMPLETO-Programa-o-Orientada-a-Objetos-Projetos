using System.Globalization;

namespace ConversorDeMoedas;

class Program
{
    static void Main()
    {
        Console.Write("Qual o valor da cotação do dolar? ");
        double Cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Quantos dolares você vai comprar ");
        double Quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Valor a ser pago em reais: " + ConversorDeMoeda.Conversor(Cotacao, Quantidade).ToString("F2", CultureInfo.InvariantCulture));
    }
}
