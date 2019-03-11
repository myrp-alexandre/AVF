using System;
using System.Collections.Generic;

namespace AVF.Dominio
{
    public class Funcionario
    {
        protected Funcionario() { }

        public Funcionario(string nome, string email, DateTime dataNascimento, Usuario usuario)
        {
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            Usuario = usuario;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public Usuario Usuario { get; set; }

        public virtual IEnumerable<Avaliacao> Avaliacoes { get; set; }
        public virtual IEnumerable<Endereco> Enderecos { get; set; }
    }
}
