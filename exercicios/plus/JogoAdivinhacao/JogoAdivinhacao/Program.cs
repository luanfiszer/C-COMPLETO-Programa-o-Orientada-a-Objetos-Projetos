namespace JogoAdivinhacao;

class Program
{
    static void Main()
    {
        Console.WriteLine("Adivinhe o número de 1 a 50");
        Console.WriteLine("---------------------------");
        Numero numero = new Numero();

        int tentativas = 0;
        int chute = 0;

        while (numero.Validador(chute) == false)
        {
            tentativas++;
            Console.Write($"TENTATIVA {tentativas}: ");
            chute = int.Parse(Console.ReadLine());
            

            if (chute < 1 || chute > 50)
            {
                Console.WriteLine("NÚMERO INVÁLIDO");
            }
            else
            {
                if (numero.Validador(chute) == false)
                {
                    numero.Dica(chute);
                }
                else
                {
                    Console.WriteLine("ACERTOU");
                }
            }
            
        }
        
    }
}