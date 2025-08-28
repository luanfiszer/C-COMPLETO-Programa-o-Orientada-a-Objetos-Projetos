namespace ConversorDeMoedas;

public class ConversorDeMoeda
{
    public static double iof = 1.06;
    public static double Conversor(double cot, double quant)
    {
        double total = quant * cot;
        return total * iof;
    }
}
