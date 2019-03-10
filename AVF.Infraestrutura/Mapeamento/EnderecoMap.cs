using AVF.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace AVF.Infraestrutura.Mapeamento
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Cep)
              .HasMaxLength(8);

            builder.Property(x => x.Logradouro)
             .HasMaxLength(50);

            builder.Property(x => x.Complemento)
             .HasMaxLength(100);

            builder.Property(x => x.Bairro)
             .HasMaxLength(50);

            builder.Property(x => x.Localidade)
             .HasMaxLength(50);

            builder.Property(x => x.Uf)
             .HasMaxLength(2);

        }
    }
}
