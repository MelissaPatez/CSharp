using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4");

            double salario;
            salario = 1234.4;

            int salarioInteiro;
            salarioInteiro = (int)salario;
            //(int) - converte 

            Console.WriteLine(salarioInteiro);

            long idade;
            idade = 123456789098765432;
            //long é um numero inteiro que suporta 64bits

            short quantidadeProduto;
            quantidadeProduto = 150;
            //short é para numeros de 16btis

            float altura;
            altura = 1.80f;

            int teste = 1234;






            Console.WriteLine("tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
