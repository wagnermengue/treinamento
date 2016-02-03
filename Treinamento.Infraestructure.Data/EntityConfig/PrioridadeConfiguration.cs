using System.Data.Entity.ModelConfiguration;
using Treinamento.Domain.Entities;

namespace Treinamento.Infraestructure.Data.EntityConfig
{
    public class PrioridadeConfiguration : EntityTypeConfiguration<Prioridade>
    {
        public PrioridadeConfiguration()
        {
            HasKey(p => p.IdPrioridade);
        }

    }
}
