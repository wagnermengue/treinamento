using System.Data.Entity.ModelConfiguration;
using Treinamento.Domain.Entities;

namespace Treinamento.Infraestructure.Data.EntityConfig
{
    public class ContatoConfiguration : EntityTypeConfiguration<Contato>
    {
        public ContatoConfiguration()
        {
            HasKey(e => e.IdContato);
        }

    }
}
