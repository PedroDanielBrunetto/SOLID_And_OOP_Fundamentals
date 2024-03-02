namespace ClassAndObject
{
    class Pessoa
    {
        // field (Definindo um campo)
        public string nome; //Por ser público, vai ser visível (Caso fosse private, não seria visível fora dessa classe)
        public int idade;
        public string genero;

        // Construtor padrão
        public Pessoa()
        {
        }

        // Criando construtor com parâmetros
        public Pessoa(string nome, int idade, string genero)
        {
            // this serve para diferenciar o nome dos campos para o nome dos parâmetros
            this.nome = nome;
            this.idade = idade;
            this.genero = genero;
        }

        public Pessoa(string nome)
        {
            this.nome = nome;
        }

        // void é um tipo de retorno de um método (ou uma função local) para especificar que tal método não retorna valor.
        public void Identificar()
        {
            // interpolação de string
            System.Console.WriteLine($"Olá, sou o {nome} tenho {idade} e sou do sexo {genero}");
        }
    }
}
