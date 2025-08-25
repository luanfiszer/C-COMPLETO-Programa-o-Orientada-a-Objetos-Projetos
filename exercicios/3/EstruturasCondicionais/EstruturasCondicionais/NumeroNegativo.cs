namespace EstruturasCondicionais;

class NumeroNegativo
{
    static void numeroNegativo()
    {
        int a = int.Parse(Console.ReadLine());
        
        if (a < 0)
        {
            Console.WriteLine("NEGATIVO");
        }
        else
        {
            Console.WriteLine("NÃO NEGATIVO");
        }
    }
}