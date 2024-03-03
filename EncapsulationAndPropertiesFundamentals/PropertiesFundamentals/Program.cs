using System;

namespace PropertiesFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tem que passar um nome, porque coloquei no construtor o parâmetro nome
            Pessoa p1 = new Pessoa("Pedro");
            // p1.Nome = ""; (O código a esquerda retorna um erro porque declarei a propriedade como somente leitura)
            p1.Genero = "Masculino";
            p1.Idade = 20;

            Console.WriteLine(p1.Nome);
            Console.WriteLine(p1.Idade);
            // Console.WriteLine(p1.Genero); (O código a esquerda retorna um erro porque declarei a propriedade como somente escrita)

            /*
                Encapsulamento:
                    É o processo de ocultar ou esconder os membros de uma classe do acesso exterior usando modificadores de acesso.
                    É conhecido como ocultação de informação ou information hiding.
                    Fornece uma maneira de preservar a integridade dos dados.

                Propriedade:
                    Uma propriedade é como uma combinação de uma variável e um método, e possui dois métodos: um get e um set.


                Código comentado:

                // No código abaixo estamos encapsulando o membro nome, utilizando a propriedade.
                private string nome;
                public string Nome
                {
                    get { return nome; }
                    set { nome = value; }
                }
                // Na linguagem C#, o código acima é abreviado e mais utilizado de tal maneira:
                /* public string Nome { get; set; } */
            // Chamada propriedades automáticas, não definimos o campo e usamos somente a propriedade com get e set

            // Posso também definir uma propriedade como somente leitura:
            /* public string Nome { get; } */

            // Posso também definir uma propriedade como somente escrita:
            /* 

                private string genero;

                public string Genero {
                    set{
                        genero = value;
                        console.WriteLine(genero);
                    }
                }

            */


        }
    }
}
