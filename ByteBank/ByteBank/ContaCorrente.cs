using System;

public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numeroConta;
    public double saldo = 200;

    public bool Sacar (int valor)
    {
        if(this.saldo > valor)
        {
            this.saldo -= valor;
            return true;
        }
        return false;
    }
}
