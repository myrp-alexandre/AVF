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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies(false)
                .UseSqlServer(@"Server=.\sqlexpress;Database=EVF;Trusted_Connection=True;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FuncionarioMap());
        }


        DbSet<Funcionario> Funcionarios { get; set; }
        DbSet<Usuario> Usuarios { get; set; }
        DbSet<Avaliacao> Avaliacoes { get; set; }
        DbSet<Endereco> Enderecos { get; set; }
    }
}
