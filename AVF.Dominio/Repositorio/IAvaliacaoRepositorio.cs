using System;
using System.Collections.Generic;
using System.Text;

namespace AVF.Dominio.Repositorio
{
    public interface IAvaliacaoRepositorio
    {
        void Salvar(Avaliacao avaliacao);
        void Atualizar(Avaliacao avaliacao);
        Avaliacao ObterAvaliacaoPorId(int id);
        Avaliacao ObterAvaliacaoPorFuncionarioId(int id);
    }
}
