namespace EstruturaFor;

public class Impares
{
    static void impares()
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
        
    }
}