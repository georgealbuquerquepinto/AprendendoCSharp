﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionarios
{
    class GerenteDeConta : FuncionarioAutenticavel
    {
        public GerenteDeConta(string cpf) : base(4000, cpf) { }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }

        public bool Autenticar(string senha)
        {
            return true;
        }

        internal protected override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}
