namespace EstruturasSequenciais;

public class AreaDaCircunferencia
{
    static void areaDaCircunferencia()
    {
        double raio = double.Parse(Console.ReadLine());

        double area = 3.14159 * Math.Pow(raio, 2);

        Console.WriteLine(area);
    }
}
