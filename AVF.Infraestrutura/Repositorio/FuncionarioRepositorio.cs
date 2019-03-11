using AVF.Dominio;
using AVF.Dominio.Repositorio;
using AVF.Infraestrutura.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace AVF.Infraestrutura.Repositorio
{
    public class FuncionarioRepositorio : IFuncionarioRepositorio
    {
        private readonly AVFDataContext _context;

        public FuncionarioRepositorio(AVFDataContext context)
        {
            _context = context;
        }

        public Funcionario ObterFuncionarioPorId(int id)
        {
            return _context.Funcionarios
                    .Include(x => x.Usuario)
                    .Include(x => x.Avaliacoes)
                    .Include(x => x.Enderecos)
                    .FirstOrDefault(x => x.Id == id);
        }

        public void Salvar(Funcionario funcionario)
        {
            using (var t = _context.Database.BeginTransaction())
            {
                _context.Funcionarios.Add(funcionario);
                _context.SaveChanges();
                t.Commit();
            }
            
        }

        public void Atualizar(Funcionario funcionario)
        {
            using (var t = _context.Database.BeginTransaction())
            {
                _context.Entry(funcionario).State = EntityState.Modified;
                _context.SaveChanges();
                t.Commit();
            }
           
        }

        public bool FuncionarioExiste(string email)
        {
            return _context.Funcionarios.Any(x => x.Email == email);
        }
    }
}
