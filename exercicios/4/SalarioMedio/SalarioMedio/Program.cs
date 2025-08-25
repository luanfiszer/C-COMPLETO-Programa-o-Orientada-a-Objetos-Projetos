using System.Globalization;

namespace SalarioMedio;

class Program
{
    static void Main()
    {
        Funcionario f1 = new Funcionario();
        Funcionario f2 = new Funcionario();

        Console.WriteLine("Dados do primeiro funcionario: ");
        Console.Write("Nome: ");
        f1.Nome = Console.ReadLine();
        Console.Write("Salario: ");
        f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Dados do segundo funcionario: ");
        Console.Write("Nome: ");
        f2.Nome = Console.ReadLine();
        Console.Write("Salario: ");
        f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine($"Salario médio = {(f1.Salario + f2.Salario) / 2}");
    }
}