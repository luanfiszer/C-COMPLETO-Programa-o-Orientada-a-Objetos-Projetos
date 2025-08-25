namespace estruturasSequeciais;

public class Soma
{
    static void soma()
    {
        Console.WriteLine("CALCULADORA DE SOMA");
        Console.WriteLine("---------------------");

        Console.WriteLine("Digite o primeiro valor: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor: ");
        int n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("A soma dos valores é: " + (n1 + n2));

    }
}
