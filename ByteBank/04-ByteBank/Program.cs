using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaBruno = new ContaCorrente();

            contaBruno.titular = "Bruno";

            Console.WriteLine(contaBruno.saldo);

            bool resultadoSaque = contaBruno.Sacar(500);

            Console.WriteLine(resultadoSaque);
            Console.WriteLine(contaBruno.saldo);

            contaBruno.Depositar(500);

            Console.WriteLine(contaBruno.saldo);

            ContaCorrente contaGabriela = new ContaCorrente();

            contaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo do Bruno: R$ " + contaBruno.saldo);
            Console.WriteLine("Saldo do Gabriela: R$ " + contaGabriela.saldo);

            bool resultadoTranferencia = contaBruno.Tranferir(2000, contaGabriela);

            Console.WriteLine("Saldo do Bruno: R$ " + contaBruno.saldo);
            Console.WriteLine("Saldo do Gabriela: R$ " + contaGabriela.saldo);

            Console.WriteLine("Resultado transferência: " + resultadoTranferencia);

            contaGabriela.Tranferir(100, contaBruno);

            Console.WriteLine("Saldo do Bruno: R$ " + contaBruno.saldo);
            Console.WriteLine("Saldo do Gabriela: R$ " + contaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
