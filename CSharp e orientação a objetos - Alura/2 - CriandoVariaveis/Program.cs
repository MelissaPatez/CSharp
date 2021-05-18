using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            idade = 32;
            Console.WriteLine(idade);

            idade = 10 + 5;
            Console.WriteLine(idade);

            idade = 10 + 5 * 2;
            Console.WriteLine(idade);

            idade = (10 + 5) * 2;
            Console.WriteLine("Sua idade é" + idade);
            
            Console.WriteLine("Executando projeto 2");
            Console.WriteLine("tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
