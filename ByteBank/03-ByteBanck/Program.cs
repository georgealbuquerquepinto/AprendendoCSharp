﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBanck
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaGabriela = new ContaCorrente();
            contaGabriela.titular = "Gabriela";
            contaGabriela.agencia = 863;
            contaGabriela.numero = 863452;

            ContaCorrente contaGabrielaCosta = new ContaCorrente();
            contaGabriela.titular = "Gabriela";
            contaGabriela.agencia = 863;
            contaGabriela.numero = 863452;

            Console.WriteLine("Igualdadde de tipo de referência: " + (contaGabriela == contaGabrielaCosta));

            int idade = 27;
            int idadeMaisUmaVez = 27;

            Console.WriteLine("Igualdadde de tipo de valor: " + (idade == idadeMaisUmaVez));

            contaGabriela = contaGabrielaCosta;

            Console.WriteLine(contaGabriela == contaGabrielaCosta);

            contaGabriela.saldo = 300;

            Console.WriteLine(contaGabriela.saldo);
            Console.WriteLine(contaGabrielaCosta.saldo);

            if (contaGabriela.saldo >= 100)
            {
                contaGabriela.saldo -= 100;
            }

            Console.ReadLine();
        }
    }
}
