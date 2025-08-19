using System.Globalization;

namespace EstruturasSequenciais;

public class ContasComTresValores
{
    static void Main()
    {
        Console.WriteLine("IMPRIMA O VALOR DE A");
        double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("IMPRIMA O VALOR DE B");
        double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("IMPRIMA O VALOR DE C");
        double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("TRIANGULO: " + ((a * c)/2).ToString("F3"));
        Console.WriteLine("CIRCULO: " + 3.14159 * Math.Pow(c, 2));
        Console.WriteLine("TRAPÉZIO: " + ( (a+b) / (2/c)).ToString("F3") );
        Console.WriteLine("QUADRADO: " + Math.Pow(b, 2).ToString("F3") );
        Console.WriteLine($"RETANGULO: {(a * b):F3} ");



    }
}
