using System;
using System.Collections.Generic;

namespace AVF.Dominio
{
    public class Funcionario
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public Usuario Usuario { get; set; }

        public ICollection<Avaliacao> Avaliacoes { get; set; }
        public ICollection<Endereco> Enderecos { get; set; }
    }
}
