using AVF.Dominio;
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
                .UseSqlServer(@"Server=(localdb);Database=EVF;Trusted_Connection=True;ConnectRetryCount=0");
        }

        DbSet<Funcionario> Funcionarios { get; set; }
        DbSet<Usuario> Usuarios { get; set; }
        DbSet<Avaliacao> Avaliacoes { get; set; }
        DbSet<Endereco> Enderecos { get; set; }
    }
}
