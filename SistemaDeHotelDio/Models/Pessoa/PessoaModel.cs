using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeHotelDio.Models.Pessoa
{
    internal class PessoaModel(string nome, string sobrenome)
    {
        private readonly string nome = nome;
        private readonly string sobrenome = sobrenome;

        public string Sobrenome { get { return this.sobrenome; } }
        public string Nome { get { return this.nome; } }
    }
}
