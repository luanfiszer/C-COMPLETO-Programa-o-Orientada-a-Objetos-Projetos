namespace EstruturasCondicionais;

public class ParOuImpar
{
    static void parOuImpar()
    {
        int n = int.Parse(Console.ReadLine());  

        if (n % 2 == 0)
        {
            Console.WriteLine("PAR");
        }
        else
        {
            Console.WriteLine("IMPAR");
        }
    }
}
