using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5");

            char primeiraLetra = 'a';
            // só usar '' aspas simples
            //só cabe um caracter
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "alura curso!";
            Console.WriteLine(titulo);

            string cursos = " - .net" + "- java";
            Console.WriteLine(cursos);

            //para quebrar linha na string tem q usar @ antes das "
            string cursos2 = @"
- .net 
- Java
- JavaScript";
            Console.WriteLine(cursos2);




            Console.WriteLine("tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
