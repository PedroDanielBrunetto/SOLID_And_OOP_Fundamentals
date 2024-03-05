using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModel
{
    public class ClienteRico
    {
        // Deixando a opção de setar valores privada.

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Endereco { get; private set; }

        public ClienteRico(int id, string nome, string endereco)
        {
            /*
                if (id < 0)
                    throw new InvalidOperationException("Id inválido");

                if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(endereco))
                    throw new InvalidOperationException("Nome e/ou Endereço inválido");
            */
            // No lugar do código acima, utilizarei o método para validar exception:

            DomainExceptionValidation.When(id < 0, "O Id não pode ser negativo");
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "O nome deve ser informado");
            DomainExceptionValidation.When(string.IsNullOrEmpty(endereco), "O endereço deve ser informado");

            Id = id;
            Nome = nome;
            Endereco = endereco;

            // Setando os valores dentro de um construtor da mesma classe, apenas após uma validação.
        }
    }
}
