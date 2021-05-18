
namespace _07_ByteBank_Construtores
{
    //primeira class 
    public class ContaCorente
    {
        private double _saldo = 100;
        private int _agencia;
        public Cliente Titular { get; set; }
        public int Numero { get; set; }

        public static int TotalDeContasCriadas { get; private set; }

        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    if(value <= 0)
                    {
                        return;
                    }
                    else
                    {
                        _agencia = value;
                    }
                }
            }
        }
        
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    this._saldo = value;
                }
            }
        }

       
        public ContaCorente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }

        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                return true;
            }
        }

        //função sem retorno 
        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}
