


//primeira class 
public class ContaCorente
{
    //para ter um valor padrao é so atribuir o valor dentro da class
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100;

    //primeira funcao
    public bool Sacar(double valor)
    {
        if (this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            return true;
        }
    }

    //função sem retorno 
    public void Depositar( double valor)
    {
        this.saldo += valor;
    }

    public bool Transferir(double valor, ContaCorente contaDestino)
    {
        if (this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}