namespace AlunoAprovado;

public class Aluno
{
    public string Nome;
    public double Trimestre1;
    public double Trimestre2;
    public double Trimestre3;

    public double NotaFinal()
    {
        double NotaFinal = Trimestre1 + Trimestre2 + Trimestre3;
        return NotaFinal;
    }

    public bool Aprovado()
    {
        if (NotaFinal() >= 60)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public double NotaRestante()
    {
        if (Aprovado())
        {
            return 0;
        }
        else
        {
            return 60 - NotaFinal();
        }
    }
}
