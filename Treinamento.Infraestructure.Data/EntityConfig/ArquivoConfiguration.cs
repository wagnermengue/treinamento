using System.Data.Entity.ModelConfiguration;
using Treinamento.Domain.Entities;

namespace Treinamento.Infraestructure.Data.EntityConfig
{
    public class ArquivoConfiguration : EntityTypeConfiguration<Arquivo>
    {
        public ArquivoConfiguration()
        {
            HasKey(a => a.IdArquivo);
        }

    }
}
