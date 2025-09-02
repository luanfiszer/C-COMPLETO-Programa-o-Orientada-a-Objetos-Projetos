namespace VetoresEx1;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double[] vet = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Imprima a {i + 1}° altura");
            vet[i] = double.Parse(Console.ReadLine());
        }

        double sum = 0.0;
        for (int i = 0; i < n; i++)
        {
            sum += vet[i];
        }

        double avg = sum / n;

        Console.WriteLine($"AVERAGE HEIGHT: {avg:F2}");
    }
}