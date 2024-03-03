using Assembly2;
using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            /* O modificador de acesso padrão para a class é Internal */
            /* O modificador de acesso padrão para os membros da class é Private */
            /* Os namespaces não tem restrição de acesso */
            /* Os modificadores de acesso ajudam a obter o encapsulamento (garantir que dados "sensíveis" sejam ocultados aos users) */

            //Se a classe estiver em outro projeto (Assembly2), deverá importar com using o projeto para poder acessar.
            Class3 c3 = new Class3();
            c3.name = "class3";
        }
    }
}
