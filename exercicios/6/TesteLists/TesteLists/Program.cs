namespace TesteList;

class Program
{
    static void Main()
    {
        List<string> list = new List<string>();
        list.Add("Maria");
        list.Add("Alex");
        list.Add("Bob");
        list.Add("Ana");
        list.Insert(2, "Marco");

        foreach (string obj in list)
        {
            Console.WriteLine(obj); 
        }

        
    }
}