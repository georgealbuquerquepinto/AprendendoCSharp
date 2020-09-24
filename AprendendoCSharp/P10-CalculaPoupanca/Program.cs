using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula poupança");

            double valorInvertido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                valorInvertido = valorInvertido + valorInvertido * 0.0036;

                Console.WriteLine("Após " + contadorMes + " meses, você terá: R$ " + valorInvertido);

                // contadorMes = contadorMes + 1;
                // contadorMes += 1;
                contadorMes++;
            }

            Console.WriteLine("A execução terminou. Precione Enter para sair.");
            Console.ReadLine();
        }
    }
}
