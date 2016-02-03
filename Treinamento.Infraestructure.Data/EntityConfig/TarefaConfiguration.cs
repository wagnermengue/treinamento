using System.Data.Entity.ModelConfiguration;
using Treinamento.Domain.Entities;

namespace Treinamento.Infraestructure.Data.EntityConfig
{
    public class TarefaConfiguration : EntityTypeConfiguration<Tarefa>
    {
        public TarefaConfiguration()
        {
            HasKey(t => t.IdTarefa);
        }

    }
}
