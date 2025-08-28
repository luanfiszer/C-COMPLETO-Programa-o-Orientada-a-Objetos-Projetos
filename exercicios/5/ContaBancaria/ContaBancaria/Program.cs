namespace ContaBancaria;

class Program
{
    static void Main(string[] arg)
    {
        Console.Write("Entre o número da conta: ");     // get , private set
        int id = int.Parse(Console.ReadLine());

        Console.Write("Entre o titular da conta: ");   // get , set
        string nome = Console.ReadLine();

        Console.Write("Haverá depósito inicial (s/n)? ");  // fazer a restrição de s/n com propeties e linkar s/n a true/false
        bool depInicial = bool.Parse(Console.ReadLine());

        Console.Write("Entre o valor de deposito inicial: $");
        double saldo = int.Parse(Console.ReadLine());

        Cliente cliente = new Cliente(id, nome, saldo);

        Console.Write("Dados da conta: ");
        Console.WriteLine(cliente);
        Console.WriteLine();

        Console.Write("Entre um valor para depósito: $");
        double deposito = int.Parse(Console.ReadLine());
        cliente.Adicionar(deposito);

        Console.Write("Dados da conta atualizados: ");
        Console.WriteLine(cliente);
        Console.WriteLine();

        Console.Write("Entre um valor para saque: $");
        double saque = double.Parse(Console.ReadLine());
        cliente.Sacar(saque);

        Console.Write("Dados da conta atualizados: ");
        Console.WriteLine(cliente);

    }
}


