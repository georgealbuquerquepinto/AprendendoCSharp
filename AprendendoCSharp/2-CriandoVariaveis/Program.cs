using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando variáveis");

            int idade;

            idade = 32;
            Console.WriteLine("Sua idade é: " + idade + ".");

            idade = 10;
            Console.WriteLine("Sua idade é: " + idade + ".");

            idade = 10 + 5;
            Console.WriteLine("Sua idade é: " + idade + ".");

            idade = 10 + 5 * 2;
            Console.WriteLine("Sua idade é: " + idade + ".");

            idade = (10 + 5) * 2;
            Console.WriteLine("Sua idade é: " + idade + ".");

            Console.WriteLine("A execução terminou. Precione Enter para sair.");
            Console.ReadLine();
        }
    }
}
