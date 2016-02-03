using System.Data.Entity.ModelConfiguration;
using Treinamento.Domain.Entities;

namespace Treinamento.Infraestructure.Data.EntityConfig
{
    public class TarefaConfiguration : EntityTypeConfiguration<Tarefa>
    {
        public TarefaConfiguration()
        {
            HasKey(t => t.IdTarefa);

            HasRequired(t => t.Projeto)
                .WithMany()
                .HasForeignKey(t => t.IdProjeto);

            HasRequired(t => t.Prioridade)
                .WithMany()
                .HasForeignKey(t => t.IdPrioridade);

            HasRequired(t => t.Status)
                .WithMany()
                .HasForeignKey(t => t.IdStatus);

            HasRequired(t => t.Pessoa)
                .WithMany()
                .HasForeignKey(t => t.Responsavel);

            HasRequired(t => t.Usuario)
                .WithMany()
                .HasForeignKey(t => t.IdUsuario);
        }

    }
}
