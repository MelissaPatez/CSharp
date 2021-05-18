using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank_Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorente conta = new ContaCorente(867, 8671245);
            Console.WriteLine(ContaCorente.TotalDeContasCriadas);

           
            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorente contaDaGabriela = new ContaCorente(867, 86745820);
            Console.WriteLine(ContaCorente.TotalDeContasCriadas);



            Console.ReadLine();
        }
    }
}
