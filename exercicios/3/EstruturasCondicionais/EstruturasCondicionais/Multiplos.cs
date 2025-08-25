namespace EstruturasCondicionais;

public class Multiplos
{
    static void multiplos()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        if (a % b == 0 || b % a ==0)
        {
            Console.WriteLine("São Multiplos");
        }
        else
        {
            Console.WriteLine("Não são Multiplos");
        }
    }
}
