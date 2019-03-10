using System;
using System.Collections.Generic;
using System.Text;

namespace AVF.Dominio
{
    public class Funcionario
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public Usuario Usuario { get; set; }
    }
}
