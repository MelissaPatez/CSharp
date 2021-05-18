using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7");

            int idadeJoao = 18;
            //int quantidadePessoa = 2;
            //bool acompanhado = quantidadePessoa >= 2;
            bool acompanhado = false;

            if (idadeJoao >= 18 && acompanhado == true  )
            {
                Console.WriteLine("pode entrar");
            }
            else
            {
                Console.WriteLine("NAO pode entrar");
            }

            Console.WriteLine("tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
