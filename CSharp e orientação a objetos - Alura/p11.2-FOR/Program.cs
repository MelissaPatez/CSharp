using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p11._2_FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 12");

            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

            for(int contadorAno=1; contadorAno <=5; contadorAno++)
            {
                for(int contadorMes = 1; contadorMes <=12; contadorMes++)
                {
                    valorInvestido *=  fatorRendimento;
                }
                fatorRendimento += 0.0010;
            }
            Console.WriteLine("ao termino foi investido " + valorInvestido);
            Console.WriteLine("tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
