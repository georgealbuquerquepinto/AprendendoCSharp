using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(457, 457123);
                ContaCorrente conta2 = new ContaCorrente(457, 457456);

                conta1.Tranferir(-1000, conta2);
            }
            catch (SaldoInsuficienteException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Catch no método Main");
            }

            Console.ReadLine();
        }

        public static void CarregarContas()
        {
            using (LeitorDeArquivo leitor = new LeitorDeArquivo("teste.txt"))
            {
                // IDisposable
                leitor.LerProximaLinha();
            }

            // ---------------------------------------

            //LeitorDeArquivo leitor = null;

            //try
            //{
            //    leitor = new LeitorDeArquivo("contas.txt");

            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //} finally
            //{
            //    Console.WriteLine("Executando o Finally");
            //    if (leitor != null)
            //        leitor.Fechar();
            //}
        }
    }
}
