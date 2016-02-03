using System.Data.Entity.ModelConfiguration;
using Treinamento.Domain.Entities;

namespace Treinamento.Infraestructure.Data.EntityConfig
{
    public class ProjetoConfiguration : EntityTypeConfiguration<Projeto>
    {
        public ProjetoConfiguration()
        {
            HasKey(p => p.IdProjeto);
        }

    }
}
