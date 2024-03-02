using System;

namespace ClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Usando o construtor padrão da classe (não recebe parâmetros, se não especificar, ele deixa como null e 0)
            // Para criar um objeto do tipo Pessoa, coloco o nome do objeto e a palavra chave new para indicar que estou criando uma instância da classe Pessoa (Instânciando a classe)
            // pessoa1 é um objeto do tipo Pessoa
            Pessoa pessoa1 = new Pessoa();
            pessoa1.nome = "Pedro";
            pessoa1.genero = "Masculino";
            pessoa1.idade = 18;
            // Utilizando um método da class Pessoa 
            pessoa1.Identificar();

            // Usando o construtor que recebe parâmetros
            Pessoa pessoa2 = new Pessoa("Vanessa", 46, "Feminino");
            pessoa2.Identificar();

            Pessoa pessoa3 = new Pessoa("Maite");
            pessoa3.idade = 13;
            pessoa3.genero = "Feminino";
            pessoa3.Identificar();

            /*
             Concluindo:
                Um  objeto é uma instância de uma classe criado em tempo de execução usando a palavra new. Lembrando que é C#

                O construtor deve corresponder ao nome da classe e não tem tipo de retorno.
                O construtor é chamado quando o objeto é criado.
                Todas as classes possuem um construtor padrão público sem parâmetros.
                Podemos ter mais de um construtor com parâmetros distintos (Sobrecarga).

            */
        }
    }
}
