using System.Threading.Channels;
using System.Globalization;

namespace EstruturasSequenciais;

public class SalarioFuncionario
{
    static void salarioFuncionario()
    {
        Console.WriteLine("CALCULADORA DE SALARIO: ");
        Console.WriteLine("--------------------------");

        Console.Write("Número do funcionário: ");
        int nFuncionario = int.Parse(Console.ReadLine());

        Console.Write("Horas trabalhadas: ");
        int horas = int.Parse(Console.ReadLine());

        Console.Write("Valor da hora dele: ");
        double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double salario = horas * valorHora;


        Console.WriteLine("NUMBER: " + nFuncionario);
        Console.WriteLine($"SALARY: U$ {salario:F2}");



    }
}
