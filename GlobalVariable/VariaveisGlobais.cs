using System;

namespace GlobalVariable
{
    public class VariaveisGlobais
    {
            public struct Nome
            {
                public string PrimeiroNome { get; set; }
                public string Sobrenome { get; set; }
            }

            public enum Genero
            {
                Masculino = 0, Feminino = 1, Outros = 2
            }

            public struct Residencia
            {
            public string Endereco { get; set; }
            public string CodPostal { get; set; }
            public string Localidade { get; set; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
