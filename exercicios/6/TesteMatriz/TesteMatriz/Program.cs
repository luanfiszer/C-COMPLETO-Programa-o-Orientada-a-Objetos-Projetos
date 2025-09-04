namespace TesteMatriz;

class Program
{
    static void Main()
    {
        Console.WriteLine("DIGITE A ORDEM N DA MATRIZ QUADRADA: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matriz = new int[n, n];

        for (int i = 0 ; i <= n ; i++)             //No seu foreach (int i in matriz), você não consegue alterar diretamente os valores da matriz, 
        {                                        //porque o foreach entrega uma cópia de cada elemento, não a referência.
            for (int j  = 0 ; j < n ; j++)
            {
                Random rand = new Random();
                matriz[i, j] = rand.Next(-10, 11);
            }
        }

            
    }
        
    
}