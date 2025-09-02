namespace VetoresEx2;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escreva a quantidade dos produtos: ");
        int n = int.Parse(Console.ReadLine());

        Produto[] produtos = new Produto[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Escreva o nome do {i + 1}º produto: ");
            string nome = Console.ReadLine();

            Console.WriteLine($"Escreva o preço do {i + 1}º produto: ");
            double preco = double.Parse(Console.ReadLine());
            produtos[i] = new Produto(nome, preco);
        }

        double soma = 0.0;

        for (int i = 0; i < n; i++)
        {
            soma += produtos[i].Preco;
        }

        double avg = soma / n;

        Console.WriteLine($"AVARANGE PRICE: {avg}");

    }
}