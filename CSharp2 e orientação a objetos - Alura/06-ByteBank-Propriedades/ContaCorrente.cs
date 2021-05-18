
namespace _06_ByteBank_GetSet
{
    //primeira class 
    public class ContaCorente
    {
        //para ter um valor padrao é so atribuir o valor dentro da class
       // private Cliente _titular;
        private double _saldo = 100;

        //public Cliente Titular
        //{
        //get
        //{
        //return _titular;
        //}
        //set
        //{
        //_titular = value;
        //}
        //}
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }


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

        //primeira funcao
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
