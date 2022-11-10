using System;
using System.Collections.Generic;

namespace ContaBancaria
{
    internal class Program
    {
        public static int nrConta = 1;

        static void Main(string[] args)
        {
            List<ContaPoupanca> contasPoupanca = new List<ContaPoupanca>();
            List<ContaCorrente> contasCorrente = new List<ContaCorrente>();
            ContaPoupanca conta = new ContaPoupanca("Zeca", "Adegas",0,"Rua","2500","Caldas", nrConta);
            contasPoupanca.Add(conta);
            Console.WriteLine(contasPoupanca[0].PessoaConta.Nome.PrimeiroNome);
            Console.WriteLine(contasPoupanca[0].NrConta);

            nrConta++;

            ContaPoupanca conta1 = new ContaPoupanca("Zeca", "Adegas", 0, "Rua", "2500", "Caldas", nrConta);
            contasPoupanca.Add(conta1);
            Console.WriteLine(contasPoupanca[1].PessoaConta.Nome.PrimeiroNome);
            Console.WriteLine(contasPoupanca[1].NrConta);
        }
    }
}
