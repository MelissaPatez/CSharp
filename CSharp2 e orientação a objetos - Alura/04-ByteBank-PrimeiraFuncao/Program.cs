using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank_PrimeiraFuncao
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorente contaDoBruno = new ContaCorente();

            contaDoBruno.titular = "Bruno";

            Console.WriteLine(contaDoBruno.saldo);
            bool resultadoSaque = contaDoBruno.Sacar(500);
            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine(resultadoSaque);


            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);


            ContaCorente contaDaGabriela = new ContaCorente();
            contaDoBruno.titular = "Gabriela";

            Console.WriteLine("saldo do bruno:" + contaDoBruno.saldo);
            Console.WriteLine("saldo do gabriela:" + contaDaGabriela.saldo);

            bool resultadoTransferencia = contaDoBruno.Transferir(200, contaDaGabriela);
            Console.WriteLine("saldo do bruno:" + contaDoBruno.saldo);
            Console.WriteLine("saldo do gabriela:" + contaDaGabriela.saldo);
            Console.WriteLine(resultadoTransferencia);




            Console.ReadLine();
        }
    }


}
