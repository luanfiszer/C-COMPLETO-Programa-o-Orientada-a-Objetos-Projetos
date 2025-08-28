namespace ContaBancaria;

public class Cliente
{
    public int Id;
    public string Nome;
    public double Saldo;

    public Cliente(int id, string nome, double saldo)
    {
        Id = id;
        Nome = nome;
        Saldo = saldo;
    }

    public Cliente(int id, string nome)
    {
        Id = id;
        Nome = nome;
        Saldo = 0;
    }

    public override string ToString()
    {
        return $"Conta {Id}, Titular: {Nome}, Saldo: ${Saldo}";
    }

    public void Adicionar(double dep)
    {
       Saldo += dep;     
    }

    public void Sacar(double saq) { 
        Saldo -= (saq + 5);
    }
}
