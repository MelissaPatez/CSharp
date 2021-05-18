using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7");

            int idadeJoao = 16;
            int quantidadePessoa = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("pode entrar");
            }
            else
            {
                if (quantidadePessoa >= 2)
                {
                    Console.WriteLine("pode entrar, pois tem acompanhante");
                }
                else
                {
                    Console.WriteLine("NAO pode entrar");
                }

            }

            Console.WriteLine("tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
