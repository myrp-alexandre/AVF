using AVF.Dominio;
using AVF.Infraestrutura.Mapeamento;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AVF.Infraestrutura.Contexto
{
    public class AVFDataContext : DbContext
    {
        public AVFDataContext(DbContextOptions<AVFDataContext> options)
       : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new FuncionarioMap());
        }

        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
    }
}
