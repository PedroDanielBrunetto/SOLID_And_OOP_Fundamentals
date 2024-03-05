using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModel
{
    public class ClienteAnemico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }

        // Uma consequencia disso é o construtor padrão sem parâmetro, podendo atribuir valores quaisquer, sem filtro.

    }
}
