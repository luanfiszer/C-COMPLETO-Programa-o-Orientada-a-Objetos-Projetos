namespace Pensionato;

class Program
{
    static void Main()
    {
        Quarto[] quarto = new Quarto[10];

        Console.WriteLine("Quantos quartos serão alugados? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Aluguel #{i + 1}: ");
            string nome = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Quarto (0-9): ");
            int numeroQuarto = int.Parse(Console.ReadLine());

            quarto[numeroQuarto] = new Quarto(nome, email);
            
            Console.WriteLine();
        }

        for (int i = 0; i < 10 ;i++)
        {
            if (quarto[i] != null)
            {
                Console.WriteLine($"{i} : {quarto[i]}");
            }
        }


    }
}