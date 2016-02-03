using System.Data.Entity.ModelConfiguration;
using Treinamento.Domain.Entities;

namespace Treinamento.Infraestructure.Data.EntityConfig
{
    public class ArquivoConfiguration : EntityTypeConfiguration<Arquivo>
    {
        public ArquivoConfiguration()
        {
            HasKey(a => a.IdArquivo);

            HasRequired(a => a.Usuario)
                .WithMany()
                .HasForeignKey(a => a.IdUsuario);

            HasRequired(a => a.Projeto)
                .WithMany()
                .HasForeignKey(a => a.IdProjeto);
        }

    }
}
