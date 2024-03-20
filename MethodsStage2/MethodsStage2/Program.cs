using System;

namespace MethodsStage2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Métodos Estáticos
            Console.WriteLine("Soma = " + Calculadora.Somar(100, 50));
            Console.WriteLine("Subtração = " + Calculadora.Subtrair(150, 50));
            // Não precisa criar instância da classe
            // Viola o Paradigma do encapsulamento da orientação a objetos
        }
    }
}
