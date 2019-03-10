using System;
using System.Collections.Generic;
using System.Text;

namespace AVF.Dominio
{
    public class Usuario
    {
        public string Login { get; private set; }
        public string Senha { get; private set; }
        public bool Ativo { get; private set; }
    }
}
