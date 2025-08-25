namespace EstruturaWhile;

public class Posto
{
    static void Main()
    {
        int alcool = 0;
        int gasolina = 0;
        int diesel = 0;
        int fim = 0;

        int codigo = 0;

        while (codigo != 4)
        {
            codigo = int.Parse(Console.ReadLine());

            if (codigo == 1)
            {
                alcool = alcool + 1;
            }

            else if (codigo == 2)
            {
                gasolina = gasolina + 1;
            }

            else if (codigo == 3)
            {
                diesel = diesel + 1;
            }

        }

        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine($"Alcool: {alcool}");
        Console.WriteLine($"Gasolina: {gasolina}");
        Console.WriteLine($"Diesel: {diesel}");
    }
}
