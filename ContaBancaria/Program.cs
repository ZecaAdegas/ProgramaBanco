using System;

namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaPoupanca conta = new ContaPoupanca("Zeca", "Adegas",0,"Rua","2500","Caldas");
            Console.WriteLine(conta.NrConta);
            Console.WriteLine(conta.PessoaConta.Nome.PrimeiroNome);
        }
    }
}
