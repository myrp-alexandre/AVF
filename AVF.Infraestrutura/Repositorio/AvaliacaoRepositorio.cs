using AVF.Dominio;
using AVF.Dominio.Repositorio;
using AVF.Infraestrutura.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace AVF.Infraestrutura.Repositorio
{
    public class AvaliacaoRepositorio : IAvaliacaoRepositorio
    {
        private readonly AVFDataContext _context;

        public AvaliacaoRepositorio(AVFDataContext context)
        {
            _context = context;
        }

        public Avaliacao ObterAvaliacaoPorFuncionarioId(int id)
        {
            return _context.Avaliacoes
                .Include(x => x.Funcionario)
                .FirstOrDefault(x => x.FuncionarioId == id);
        }

        public Avaliacao ObterAvaliacaoPorId(int id)
        {
            return _context.Avaliacoes
               .Include(x => x.Funcionario)
               .FirstOrDefault(x => x.Id == id);
        }

        public void Salvar(Avaliacao avaliacao)
        {
            using (var t = _context.Database.BeginTransaction())
            {
                _context.Avaliacoes.Add(avaliacao);
                _context.SaveChanges();
                t.Commit();
            }

        }

        public void Atualizar(Avaliacao avaliacao)
        {
            using (var t = _context.Database.BeginTransaction())
            {
                _context.Entry(avaliacao).State = EntityState.Modified;
                _context.SaveChanges();
                t.Commit();
            } 
        }
    }
}
