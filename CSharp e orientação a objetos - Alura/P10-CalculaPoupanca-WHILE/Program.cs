using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupanca_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10");
            int contadorMes = 1;
            double valorInvestido = 1000;

            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("apos " + contadorMes + " meses vc tera " + valorInvestido);
                //contadorMes = contadorMes + 1;
                //contadorMes ++;
                contadorMes += 1;
            }

            Console.WriteLine("tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
