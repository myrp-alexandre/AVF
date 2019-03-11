using System;
using System.Collections.Generic;
using System.Text;

namespace AVF.Dominio.Repositorio
{
    public interface IFuncionarioRepositorio
    {
        void Salvar(Funcionario funcionario);
        void Atualizar(Funcionario funcionario);
        Funcionario ObterFuncionarioPorId(int id);
        bool FuncionarioExiste(string email);
    }
}
