using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaractersETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5");

            char primeiraLetra = ' ';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)61;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de tecnologia " + 2020;
            Console.WriteLine(titulo);

            string cursosProgramacao =
@"- .NET
- Java
- Javascript";
            Console.WriteLine(cursosProgramacao);

            Console.WriteLine("A execução terminou. Precione Enter para sair.");
            Console.ReadLine();
        }
    }
}
