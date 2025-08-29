namespace ContaBancaria;

public class Cliente
{
    public int Id { get; private set; }
    public string Nome { get; set; }
    public double Saldo { get; private set; }

    public Cliente(int id, string nome)   
    {
    }

    public Cliente(int id, string nome, double saldo) : this(id, nome)   // por eu ter ultizado o this() não preciso escrever Id e Nome
    {
        Id = id;
        Nome = nome;
        Saldo = saldo;
    }



    public void Deposito(double dep)
    {
        Saldo += dep;
    }

    public void Saque(double saq)
    {
        Saldo -= (saq + 5);
    }

    public override string ToString()
    {
        return $"Conta {Id}, Titular: {Nome}, Saldo: ${Saldo:F2}";
    }


}


/* ORDEM DE IMPLEMENTAÇÃO
    
    1- Atributos privados
    2- Propriedades autoimplementadas
    3- Construtores
    4- Propriedades customizadas
    5- Outros metodos
 
 
 
 */