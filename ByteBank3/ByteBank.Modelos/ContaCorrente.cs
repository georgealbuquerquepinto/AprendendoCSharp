﻿﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    /// <summary>
    /// Define uma Conta Corrente do banco ByteBank.
    /// </summary>
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }

        public static int TotalDeContasCriadas { get; private set; }

        public Cliente Titular { get; set; }

        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTranferenciasNaoPermitidas { get; private set; }

        public int Agencia { get; }

        public int Numero { get; }

        private double _saldo = 100;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                    return;
                _saldo = value;
            }
        }

        /// <summary>
        /// Cria uma instância de ContaCorrente com os argumentos utilizados.
        /// </summary>
        /// <param name="agencia">Representa o valor da propriedade <see cref="Agencia"/> e deve possuir uma valor maior que 0.</param>
        /// <param name="numero">Representa o valor da propriedade <see cref="Numero"/> e deve possuir uma valor maior que 0.</param>
        public ContaCorrente(int agencia, int numero)
        {
            if (agencia <= 0)
            {
                ArgumentException excecao = new ArgumentException("O argumento Agencia deve ser maior que 0", nameof(agencia));
                throw excecao;
            }

            if (numero <= 0)
            {
                ArgumentException excecao = new ArgumentException("O argumento Número deve ser maior que 0", nameof(numero));
                throw excecao;
            }
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }

        /// <summary>
        /// Realiza o saque e atualiza o valor da propriedade <see cref="Saldo"/>.
        /// </summary>
        /// <exception cref="ArgumentException">Exceção lançada quando um valor negativo é utilizado no argumento <paramref name="valor"/>.</exception>
        /// <exception cref="SaldoInsuficienteException">Exceção lançada quando o valor de <paramref name="valor"/> é maior que o valor da propiedade <see cref="Saldo"/>.</exception>
        /// <param name="valor">Representa o vaor do saque, deve ser maior que 0 e menor que o <see cref="Saldo"/></param>
        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para o saque.", nameof(valor));
            }
            if (_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }

            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public void Tranferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para a transferência.", nameof(valor));
            }

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                ContadorTranferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não realizada.", ex);
            }
            contaDestino.Depositar(valor);
        }
    }
}