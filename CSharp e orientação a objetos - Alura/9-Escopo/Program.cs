using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9");

            int idadeJoao = 18;
            bool acompanhado = false;
            string mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = "joão está acompanhado";
            }
            else
            {
                mensagemAdicional = "joão NAO está acompanhado";
            }

            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("pode entrar");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("NAO pode entrar");
                Console.WriteLine(mensagemAdicional);
            }

            Console.WriteLine("tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
