namespace AlunoAprovado;

class Program
{
    static void Main()
    {
        Aluno a1 = new Aluno();

        Console.Write("Qual o nomedo aluno: ");
        a1.Nome = Console.ReadLine();

        Console.WriteLine("Digite as três notas do aluno: ");

        a1.Trimestre1 = double.Parse(Console.ReadLine());
        a1.Trimestre2 = double.Parse(Console.ReadLine());
        a1.Trimestre3 = double.Parse(Console.ReadLine());

        Console.WriteLine($"NOTA FINAL = {a1.NotaFinal()}");

        if (a1.Aprovado())
        {
            Console.WriteLine("APROVADO");
        }
        else
        {
            Console.WriteLine("REPROVADO, FALTARAM " + a1.NotaRestante().ToString("F2"));

        }
    }
}