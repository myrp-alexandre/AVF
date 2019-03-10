using AVF.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AVF.Infraestrutura.Mapeamento
{
    public class AvaliacaoMap : IEntityTypeConfiguration<Avaliacao>
    {
        public void Configure(EntityTypeBuilder<Avaliacao> builder)
        {
            builder.ToTable("Avaliacao");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Comentario)
              .HasMaxLength(5000)
              .IsRequired();

            builder.Property(x => x.Nota)
              .IsRequired();

            builder.Property(x => x.DataAvaliacao);
        }
    }
}
