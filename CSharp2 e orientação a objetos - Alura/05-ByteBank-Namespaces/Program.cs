using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank_Namespaces
{
    class Program
    {
        static void Main(string[] args)
           
        {
            Cliente gabriela = new Cliente();
            gabriela.titularNome = "Gabriela";
            gabriela.titularProfissao = "Desenvolvedora C#";
            gabriela.titularCPF = "434.562.878-20";

            ContaCorente conta = new ContaCorente();
            conta.titular = gabriela;
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634527;

            Console.WriteLine(gabriela.titularNome);
            Console.WriteLine(conta.titular.titularNome);

            //conta.titular = new Cliente();
            //conta.titular.nome = "Gabriela Costa";
            //Console.WriteLine(conta.titular.nome);

            Console.ReadLine();
        }
    }
}
