namespace EstruturasCondicionais;

public class TempoDeJogo
{
    static void tempoDeJogo()
    {
        string[] valores = Console.ReadLine().Split(',');
        int h1 = int.Parse(valores[0]);
        int h2 = int.Parse(valores[1]);
        

         if (h1 >= h2)
        {
            int resultado = 24 - (h1 - h2);
            Console.WriteLine($"O JOGO DUROU {resultado} HORA(S)");
        }
        else
        {
            int resultado = h2 - h1;   
            Console.WriteLine($"O JOGO DUROU {resultado} HORA(S)");
        }

        
    }
}
