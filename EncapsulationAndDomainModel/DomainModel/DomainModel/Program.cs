using System;

namespace DomainModel
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteRico cliente = new ClienteRico(4, "Vanessa", "Rua Lobo Viana");

            Console.WriteLine($"{cliente.Id}, {cliente.Nome}, {cliente.Endereco}");

        }

        private static ClienteAnemico ClienteAnemicoTeste()
        {
            // Um método que espera retorno, deverá retornar algo.

            ClienteAnemico cli = new ClienteAnemico();
            cli.Id = -1;
            cli.Nome = "";
            cli.Endereco = null;
            return cli;
        }
    }
}
