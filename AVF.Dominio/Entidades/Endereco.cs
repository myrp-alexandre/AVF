﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AVF.Dominio
{
    public class Endereco
    {
        protected Endereco() { }

        public int Id { get; private set; }
        public string Cep { get; private set; }
        public string Logradouro { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Localidade { get; private set; }
        public string Uf { get; private set; }

        public int FuncionarioId { get; set; }
        public virtual Funcionario Funcionario { get; set; }
    }
}
