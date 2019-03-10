using AVF.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AVF.Infraestrutura.Mapeamento
{
    public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("Funcionario");
            
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Usuario);

            builder.HasMany(x => x.Avaliacoes);
            builder.HasMany(x => x.Enderecos);

            builder.Property(x => new { x.Nome, x.Email })
              .HasMaxLength(100)
              .IsRequired();

            builder.Property(x => x.DataNascimento)
              .IsRequired(); 
        }
    }
}
