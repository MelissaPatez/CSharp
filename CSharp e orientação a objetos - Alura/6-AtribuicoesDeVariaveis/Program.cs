using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 6");
            //Quando nós atribuímos o valor de uma variável para outra variável, a última não será alterada como a primeira
            int idade = 32;
            int idadeGustavo = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadeGustavo);




            Console.WriteLine("tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
