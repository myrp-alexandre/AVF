using AVF.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AVF.Infraestrutura.Mapeamento
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Login)
              .HasMaxLength(50);

            builder.Property(x => x.Senha)
             .HasMaxLength(32);

            builder.Property(x => x.Ativo);
        }
    }
}
