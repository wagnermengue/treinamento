using System.Data.Entity.ModelConfiguration;
using Treinamento.Domain.Entities;

namespace Treinamento.Infraestructure.Data.EntityConfig
{
    public class ContatoConfiguration : EntityTypeConfiguration<Contato>
    {
        public ContatoConfiguration()
        {
            HasKey(c => c.IdContato);

            HasRequired(c => c.Pessoa)
                .WithMany()
                .HasForeignKey(c => c.IdPessoa);

            HasRequired(c => c.TipoContato)
                .WithMany()
                .HasForeignKey(c => c.IdTipo);

            HasRequired(c => c.Usuario)
                .WithMany()
                .HasForeignKey(c => c.IdUsuario);
        }

    }
}
