using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoAdivinhacao;

public class Numero
{
    private int numeroCerto;


    public Numero()
    {
        Random rnd = new Random();
        numeroCerto = rnd.Next(1, 51);
    }
    

    public bool Validador(int chute)
    {
        if (chute == numeroCerto )
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Dica(int chute)
    {
        if( chute > numeroCerto )
        {
            Console.WriteLine("MAIS BAIXO");
        }
        else if( chute < numeroCerto )
        {
            Console.WriteLine("MAIS ALTO");
        }
    }
}
