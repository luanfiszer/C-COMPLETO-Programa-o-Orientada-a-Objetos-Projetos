namespace AumentoFuncionario;

class Program
{
    static void Main()
    {
        Funcionario f1 = new Funcionario();

        Console.Write("Nome: ");
        f1.Nome = Console.ReadLine();

        Console.Write("Salario Bruto: ");
        f1.SalarioBruto = double.Parse(Console.ReadLine());

        Console.Write("Imposto: ");
        f1.Imposto = double.Parse(Console.ReadLine());

        Console.WriteLine($"Funcionario: {f1}");

        Console.Write("Digite a porcentagem para aumetar o salario: ");
        double percent = double.Parse(Console.ReadLine());

        f1.AumentarSalario(percent);

        Console.WriteLine();
        Console.WriteLine($"Dados atualizados: {f1}");

       
        
    }
}