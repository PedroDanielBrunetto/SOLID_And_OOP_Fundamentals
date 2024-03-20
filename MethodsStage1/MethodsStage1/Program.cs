using System;

namespace MethodsStage1
{
    class Program
    {
        static public int Somar(int n1, int n2)
        {
            return n1 + n2;
        }

        static public double Somar(double n1, int n2)
        {
            return n1 + n2;
        }

        static public int Somar(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }

        static public int Somar(params int[] numeros)
        {
            var resultado = 0;
            foreach (var num in numeros)
                resultado = resultado + num; //resultado += num;
            return resultado;
        }

        static public int Opcional(int x, int y=20, int z=30, int w = 50)
        {
            return x + y + z + w;
            // Parâmetro X é obrigatório, os outros são opcionais, se não forem imputados, virão com valor padrão
            // A declaração de Parâmetros opcionais vem sempre após os obrigatórios.
        }

        static public void Enviar(string destino, string nome, string assunto)
        {
            Console.WriteLine($"{destino} - {nome} - {assunto}");
        }

        static void Main(string[] args)
        {
            var resultado = Somar(100, 200);

            var resultado2 = Program.Somar(100, 200, 300);

            var resultado3 = Somar(1, 2, 3, 4);

            var resultado4 = Somar(new int[] { 1, 2, 3 });

            int op1 = Program.Opcional(100);
            int op2 = Opcional(100, 200);
            int op3 = Opcional(100, 200, 300);
            int op4 = Opcional(100, 200, 300, 400);

            Enviar(destino: "pedrodanielbm@hotmail.com", assunto: "curriculo", nome: "Pedro Daniel");

            Console.WriteLine("Resultado 1: " 
                + resultado + 
                "\nResultado 2: " 
                + resultado2 + 
                "\nResultado3: "
                + resultado3 +
                "\nResultado4: "
                + resultado4 +
                "\nDeclaração de Parâmetros Opcionais:\n"
                + op1 + "\n" + op2 + "\n" + op3 + "\n" + op4
                );
        }
    }
}
