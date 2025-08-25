namespace EstruturasCondicionais;

public class ValorDaConta
{
    static void valorDaConta()
    {
        string[] pedido = Console.ReadLine().Split(' ');
        int codigo = int.Parse(pedido[0]);
        int quantidade = int.Parse(pedido[1]);
        double valor = 0.0;

        if (codigo == 1)
        {
            valor = quantidade * 4.00;
        }   

        else if (codigo == 2)
        {
            valor = quantidade * 4.50;
        }

        else if (codigo == 3)
        {
            valor = quantidade * 5.00;
        }

        else if (codigo == 4)
        {
            valor = quantidade * 2.00;
        }

        else if (codigo == 5)
        {
            valor = quantidade * 1.50;
        }

        Console.WriteLine($"Total: R$ {valor:F2} ");







    }
}
