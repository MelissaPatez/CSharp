using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p11_CalculaPoupanca2_FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 11");
            int contadorMes = 1;
            double valorInvestido = 1000;

            for(contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("apos " + contadorMes + " meses vc tera " + valorInvestido);
            }


            Console.WriteLine("tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
