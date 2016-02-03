using System.Data.Entity.ModelConfiguration;
using Treinamento.Domain.Entities;

namespace Treinamento.Infraestructure.Data.EntityConfig
{
    public class ProjetoConfiguration : EntityTypeConfiguration<Projeto>
    {
        public ProjetoConfiguration()
        {
            HasKey(p => p.IdProjeto);

            HasRequired(p => p.Pessoa)
                .WithMany()
                .HasForeignKey(p => p.IdPessoa);

            HasRequired(p => p.PessoaResponsavel)
                .WithMany()
                .HasForeignKey(p => p.Responsavel);

            HasRequired(p => p.Status)
                .WithMany()
                .HasForeignKey(p => p.IdStatus);

            HasRequired(p => p.Usuario)
                .WithMany()
                .HasForeignKey(p => p.IdUsuario);

        }

    }
}
