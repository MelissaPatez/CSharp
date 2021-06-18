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

            Funcionario carlos = new Funcionario(2000, "23456789456");
            carlos.Nome = "Carlos";
            gerenciador.Registrar(carlos);
            carlos.AumentarSalario();
            Console.WriteLine("Aumento de salario " + carlos.Salario);

            Diretor fabio = new Diretor("123456789");
            fabio.Nome = "Fabio";
            gerenciador.Registrar(fabio);
            fabio.AumentarSalario();
            Console.WriteLine("Aumento de salario " + fabio.Salario);

            Console.WriteLine(Funcionario.TotalFuncionario);
            Console.WriteLine(carlos.GetBonificacao());
            Console.WriteLine(fabio.GetBonificacao());
            Console.WriteLine("Total bonificação: " + gerenciador.GetTotalBonificacao());
            Console.ReadLine();
        }
    }
}
