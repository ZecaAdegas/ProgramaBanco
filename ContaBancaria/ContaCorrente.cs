using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    class ContaCorrente : Conta
    {
        public ContaCorrente(string nome, string sobreNome, int genero, string endereco, string codPostal, string localidade, int nrConta)
        {
            this.PessoaConta = new();
            PessoaConta.Nome.PrimeiroNome = nome;
            PessoaConta.Nome.Sobrenome = sobreNome;
            PessoaConta.Genero = (GlobalVariable.VariaveisGlobais.Genero)genero;
            PessoaConta.Morada.Endereco = endereco;
            PessoaConta.Morada.CodPostal = codPostal;
            PessoaConta.Morada.Localidade = localidade;
            NrConta = nrConta;
            Saldo = 0;
        }
    }
}
