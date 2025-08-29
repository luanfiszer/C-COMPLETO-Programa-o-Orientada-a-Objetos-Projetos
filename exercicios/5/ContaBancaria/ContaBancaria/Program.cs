namespace ContaBancaria;

class Program
{
    static void Main(string[] arg)
    {

        Cliente conta;

        Console.Write("Entre o número da conta: ");     // get , private set
        int id = int.Parse(Console.ReadLine());

        Console.Write("Entre o titular da conta: ");   // get , set
        string nome = Console.ReadLine();

        Console.Write("Haverá depósito inicial (s/n)? ");  // fazer a restrição de s/n com propeties e linkar s/n a true/false
        char depInicial = char.Parse(Console.ReadLine());

        double saldo = 0.0;
        if (depInicial == 's' || depInicial == 'S')
        {
            Console.Write("Entre o valor de deposito inicial: $");
            saldo = double.Parse(Console.ReadLine());
            conta = new Cliente(id, nome, saldo);
        }

        else
        {
            conta = new Cliente(id, nome);
        }

        Console.Write("Dados da conta: ");
        Console.WriteLine(conta);
        Console.WriteLine();

        Console.Write("Entre um valor para depósito: $");
        double deposito = double.Parse(Console.ReadLine());
        conta.Deposito(deposito);

        Console.Write("Dados da conta atualizados: ");
        Console.WriteLine(conta);
        Console.WriteLine();

        Console.Write("Entre um valor para saque: $");
        double saque = double.Parse(Console.ReadLine());
        conta.Saque(saque);

        Console.Write("Dados da conta atualizados: ");
        Console.WriteLine(conta);

    }
}


