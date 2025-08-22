namespace EstruturaFor;

public class DentroDoIntervalo
{
    static void dentroDoIntervalo()
    {
        int N = int.Parse(Console.ReadLine());
        int dentro = 0;
        int fora = 0;

        for (int i = 1 ; i <= N; i++)
        {
            int k = int.Parse(Console.ReadLine());

            if (k >= 10 && k <= 20)
            {
                dentro++;
            }

            else
            {
                fora++;
            }
        }

        Console.WriteLine($"{dentro} in");
        Console.WriteLine($"{fora} out");
    }
}
