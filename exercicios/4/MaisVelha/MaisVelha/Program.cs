namespace MaisVelha;

public class Program
{
    static void Main()
    {
        Pessoa p1, p2;      // declarei

        p1 = new Pessoa();   // instanciei
        p2 = new Pessoa();

        Console.WriteLine("Dados da primeira pessoa:");
        Console.Write("Nome: ");
        p1.Nome = Console.ReadLine();
        Console.Write("Idade: ");
        p1.Idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Dados da segunda pessoa:");
        Console.Write("Nome: ");
        p2.Nome = Console.ReadLine();
        Console.Write("Idade: ");
        p2.Idade = int.Parse(Console.ReadLine());

        string maisVelho;

        if (p1.Idade > p2.Idade)
        {
            Console.WriteLine($"Pessoa mais velha: {p1.Nome}");
        }
        else
        {
            Console.WriteLine($"Pessoa mais velha: {p2.Nome}");
        }

        

        


    }
    

    
   
}