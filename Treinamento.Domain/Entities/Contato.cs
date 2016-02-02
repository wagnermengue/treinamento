using System;

namespace Treinamento.Domain.Entities
{
    public class Contato
    {
        public int IdContato { get; set; }
        public int IdPessoa { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public string Descricao { get; set; }
        public int IdTipo { get; set; }
        public virtual TipoContato TipoContato { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public int IdUsuario { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
