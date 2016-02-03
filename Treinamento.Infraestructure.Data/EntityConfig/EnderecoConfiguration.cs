using System.Data.Entity.ModelConfiguration;
using Treinamento.Domain.Entities;

namespace Treinamento.Infraestructure.Data.EntityConfig
{
    public class EnderecoConfiguration : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfiguration()
        {
            HasKey(e => e.IdEndereco);

            HasRequired(e => e.Pessoa)
                .WithMany()
                .HasForeignKey(e => e.IdPessoa);

            HasRequired(e => e.Usuario)
                .WithMany()
                .HasForeignKey(e => e.IdUsuario);
        }

    }
}
