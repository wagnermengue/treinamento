using System;
using System.Data.Entity.ModelConfiguration;
using Treinamento.Domain.Entities;

namespace Treinamento.Infraestructure.Data.EntityConfig
{
    public class PessoaConfiguration : EntityTypeConfiguration<Pessoa>
    {
        public PessoaConfiguration()
        {
            HasKey(p => p.IdPessoa);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(150);
        }

    }
}
