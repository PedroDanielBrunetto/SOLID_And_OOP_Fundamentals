using System;

namespace UpCastingDownCast
{
    class Program
    {
        static void Main(string[] args)
        {
            //DownCasting_as();
            Circulo circulo = new Circulo();
            Forma f = circulo;

            if (f is Circulo) //Verifico se a conversão é possível
                ((Circulo)f).PintarCirculo();
        }

        private static void DownCasting_as()
        {
            //DownCasting();
            Forma f = new Forma();
            Circulo c = f as Circulo;
            if (c != null)
                c.PintarCirculo();
            else
                Console.WriteLine("Operação Inválida");
        }

        private static void DownCasting()
        {
            //UpCasting();
            Circulo circulo = new Circulo();
            Forma f = circulo; //upCasting -> implicita

            Circulo c = (Circulo)f;

            Console.WriteLine(c == f);
            Console.WriteLine(c == circulo);

            Console.ReadLine();
        }

        private static void UpCasting()
        {
            Circulo circulo = new Circulo();
            Forma f = circulo; //UpCasting

            Console.WriteLine(f == circulo);

            f.Desenhar();
        }
    }
}
