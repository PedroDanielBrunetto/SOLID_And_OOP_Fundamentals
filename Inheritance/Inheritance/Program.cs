using System;

namespace Inheritance
{
    class Program
    {

        class Conta
        {
            public int Numero { get; set; }
            public double Saldo { get; set; }

            protected virtual void GetSaldo()
            {
                Console.WriteLine("Saldo {0}", Numero);
            }
            public Conta()
            {
                Console.WriteLine("Primeiro ele chama o construtor da classe base");
            }
        }

        class ContaPoupanca : Conta
        {
            public int JurosMensais { get; set; }
            protected override void GetSaldo()
            {
                Console.WriteLine("Saldo 10");
            }
            static void Main(string[] args)
            {
                ContaPoupanca cp = new ContaPoupanca();
                cp.Numero = 10;
                cp.Saldo = 499.90;
                cp.JurosMensais = 0;
                cp.GetSaldo();
            }
        }
    }
}
