﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AVF.Dominio
{
    public class Usuario
    {
        protected Usuario() { }

        public Usuario(string login, string senha, bool ativo)
        {
            Login = login;
            Senha = senha;
            Ativo = ativo;
        }

        public int Id { get; private set; }
        public string Login { get; private set; }
        public string Senha { get; private set; }
        public bool Ativo { get; private set; }
    }
}
