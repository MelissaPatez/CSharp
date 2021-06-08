using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario();
            carlos.Nome = "Carlos";
            carlos.CPF = "23456789456";
            carlos.Salario = 2000;
            gerenciador.Registrar(carlos);

            Diretor fabio = new Diretor();
            fabio.Nome = "Fabio";
            fabio.CPF = "123456789";
            fabio.Salario = 5000;
            gerenciador.Registrar(fabio);

            Console.WriteLine(carlos.GetBonificacao());
            Console.WriteLine(fabio.GetBonificacao());
            Console.WriteLine("Total bonificação: " + gerenciador.GetTotalBonificacao());
            Console.ReadLine();
        }
    }
}
