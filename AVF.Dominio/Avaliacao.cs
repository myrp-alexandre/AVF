﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AVF.Dominio
{
    public class Avaliacao
    {
        public int Id { get; private set; }
        public string Comentario { get; private set; }
        public int Nota { get; private set; }
        public DateTime DataAvaliacao { get; private set; }
    }
}
