using System;

namespace ThisFundamentals
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            /*
              Concluindo:
                Palavra this refere-se à instância atual da classe.
                É usada com um modificador do primeiro parâmetro de um método de extensão.
                É principalmente usada para qualificar membros ocultados por nomes semelhantes (evitar ambiguidade) e passar um objeto como parâmetro para outros métodos.  
                This não pode ocorrer dentro de uma classe estática
             */
        }
    }
}
