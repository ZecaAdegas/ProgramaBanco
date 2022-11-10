using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    abstract class Conta  {

        public Pessoa PessoaConta;

        public virtual int NrConta { get; set; }

        public virtual double Saldo { get; set; }

        

    }
}
