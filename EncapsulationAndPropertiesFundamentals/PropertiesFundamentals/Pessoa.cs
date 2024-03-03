using System;
using System.Collections.Generic;
using System.Text;

namespace PropertiesFundamentals
{
    public class Pessoa
    {
        private string nome;
        private string genero;
        private int idade;

        // Todas as propriedades tem que ser públicas, do tipo dos membros e geralmente o mesmo nome do campo, diferenciando com maiusculo

        // Construtor
        public Pessoa(string nome)
        {
            this.Nome = nome;
        }

        public string Nome { get; }

        public string Genero
        {
            set
            {
                genero = value;
                Console.WriteLine(genero);
            }
        }

        public int Idade
        {
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Idade tem que ser maior que 18.");
                }
                else
                {
                    this.idade = value;
                }
            }
            get { return idade; }
        }
    }
}
