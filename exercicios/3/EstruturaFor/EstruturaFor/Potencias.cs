namespace EstruturaFor;

public class Potencias
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            for (int k = 1; k <= 10; k++)
            {
                long resultado = (long)Math.Pow(i, k);

                Console.Write($"{resultado}");
                
            }
                Console.WriteLine(" ");
        }
    }
}
