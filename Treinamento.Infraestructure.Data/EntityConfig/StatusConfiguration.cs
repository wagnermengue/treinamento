using System.Data.Entity.ModelConfiguration;
using Treinamento.Domain.Entities;

namespace Treinamento.Infraestructure.Data.EntityConfig
{
    public class StatusConfiguration : EntityTypeConfiguration<Status>
    {
        public StatusConfiguration()
        {
            HasKey(s => s.IdStatus);
        }

    }
}
