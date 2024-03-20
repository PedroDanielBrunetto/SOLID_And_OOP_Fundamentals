using System;
using MethodsStage3.Utils;

namespace MethodsStage3
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto1 = "curso";
            var texto2 = "marimex";

            //string são imutaveis
            //métodos de extensão
            texto1 = texto1.CaixaAltaPrimeiraLetra();
            texto2 = texto2.CaixaAltaPrimeiraLetra();

            Console.WriteLine(texto1);
            Console.WriteLine(texto2);
        }
    }
}
