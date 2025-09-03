using System.Diagnostics.CodeAnalysis;

namespace SomaParams;

class Program
{
    static void Main()
    {
       int s1 = (int)Calculator.Sum(1, 2, 3);  // deixei o (int) para lembrar do casting

        Console.WriteLine(s1);
    }
}