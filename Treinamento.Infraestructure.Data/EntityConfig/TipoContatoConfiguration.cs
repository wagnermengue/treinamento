using System.Data.Entity.ModelConfiguration;
using Treinamento.Domain.Entities;

namespace Treinamento.Infraestructure.Data.EntityConfig
{
    public class TipoContatoConfiguration : EntityTypeConfiguration<TipoContato>
    {
        public TipoContatoConfiguration()
        {
            HasKey(t => t.IdTipoContato);
        }

    }
}
